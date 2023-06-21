#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace EDTool
{
    public partial class MnForm : Form
    {

        #region VARs
        private const int Keysize = 256;
        private const int DerivationIterations = 1000;

        private bool AllowActions = false;
        private string Version = "Beta 0.3";
        private string PssCode = "IAmABloodyFool";

        // This constant determines the number of iterations for the password bytes generation function.
        #endregion

        #region WINAPI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region ENCRYPT / DECRYPT FUNCTIONS
        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
        #endregion

        #region MAIN FORM
        public MnForm()
        {
            InitializeComponent();
        }

        private void MnForm_Load(object sender, EventArgs e)
        {
            LbVersion.Text = "Version " + Version;
            FadeIn.Start();
        }
        private void MnForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region MOUSE ENTER
        private void HandleMouseEnter(object sender, EventArgs e)
        {
            #region PICTURE BOXES
            if (sender is PictureBox)
            {
                PictureBox Pic = (PictureBox)sender;
                if (Pic.Name == "ClipboardIco") Pic.Image = Properties.Resources.ico32c_clipboard1;
                if (Pic.Name == "CloseBt") Pic.Image = Properties.Resources.ico24c_close2;
                if (Pic.Name == "EncodeIco") Pic.Image = Properties.Resources.ico32c_encode1;
                if (Pic.Name == "MinimizeIco") Pic.Image = Properties.Resources.ico24c_minimize1;
                if (Pic.Name == "SaveToFileIco") Pic.Image = Properties.Resources.ico32c_save1;
                if (Pic.Name == "SettingsIco") Pic.Image = Properties.Resources.ico32c_settings1;
            }
            #endregion
        }
        #endregion

        #region MOUSE LEAVE
        private void HandleMouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox Pic = (PictureBox)sender;
                if (Pic.Name == "ClipboardIco") Pic.Image = Properties.Resources.ico32c_clipboard2;
                if (Pic.Name == "CloseBt") CloseBt.Image = Properties.Resources.ico24c_close1;
                if (Pic.Name == "EncodeIco") Pic.Image = Properties.Resources.ico32c_encode2;
                if (Pic.Name == "MinimizeIco") MinimizeIco.Image = Properties.Resources.ico24c_minimize2;
                if (Pic.Name == "SaveToFileIco") Pic.Image = Properties.Resources.ico32c_save2;
                if (Pic.Name == "SettingsIco") Pic.Image = Properties.Resources.ico32c_settings2;
            }
        }
        #endregion

        #region MOUSE UP
        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox Pic = (PictureBox)sender;
                
                if (Pic.Name == "CloseBt" && e.Button == MouseButtons.Left) FadeOut.Start();
                
               
                if (Pic.Name == "ClipboardIco")
                {
                    if (TbEncoded.Text != "")
                        Clipboard.SetText(TbEncoded.Text);
                }
                
                if (Pic.Name == "EncodeIco")
                {
                    if (TbSource.Text != "")
                        TbEncoded.Text = Encrypt(TbSource.Text, PssCode);
                    else
                    {
                        TbEncoded.Text = "";
                        this.ActiveControl = TbSource;
                    }
                }

                if (Pic.Name == "MinimizeIco" && e.Button == MouseButtons.Left) this.WindowState = FormWindowState.Minimized;
            
                if (Pic.Name == "SaveToFileIco")
                {
                    if (e.Button == MouseButtons.Left)
                        if (TbEncoded.Text != "")
                            if (SvFileDialog.ShowDialog() == DialogResult.OK)
                                MessageBox.Show(SvFileDialog.FileName);
                }
            }
        }
        #endregion

        #region TIMERS
        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.99)
            {
                this.Opacity += 0.08;
            }
            else
            {
                FadeIn.Stop();
                AllowActions = true;
            }
        }

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.08;
            }
            else
            {
                FadeOut.Stop();
                Application.Exit();
            }
        }
        #endregion

    }
}
