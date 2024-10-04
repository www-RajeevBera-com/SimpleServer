using System.Net;
using System.Text;

namespace SimpleServeGUI
{
    public partial class Form1 : Form
    {
        private HttpListener listener;
        private string staticFilesDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            staticFilesDirectory = txtPath.Text;
            int port = int.Parse(txtPort.Text);
            StartWebServer(port);

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"http://localhost:{port}",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error launching browser: {ex.Message}");
            }
        }
        private void StartWebServer(int port)
        {
            try
            {
                listener = new HttpListener();
                listener.Prefixes.Add($"http://localhost:{port}/");

                listener.Start();
                MessageBox.Show($"Server started on http://localhost:{port}", "Server Running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listener.BeginGetContext(new AsyncCallback(HandleRequest), listener);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleRequest(IAsyncResult result)
        {
            HttpListenerContext context = listener.EndGetContext(result);
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            string filePath = request.Url.AbsolutePath.TrimStart('/');
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "index.html"; // Default to index.html
            }

            filePath = Path.Combine(staticFilesDirectory, filePath);

            if (File.Exists(filePath))
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                response.ContentType = GetContentType(filePath);
                response.ContentLength64 = fileBytes.Length;
                response.OutputStream.Write(fileBytes, 0, fileBytes.Length);
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                byte[] errorBytes = Encoding.UTF8.GetBytes("<h1>404 - File Not Found</h1>");
                response.OutputStream.Write(errorBytes, 0, errorBytes.Length);
            }

            response.OutputStream.Close();
            listener.BeginGetContext(new AsyncCallback(HandleRequest), listener);
        }

        private string GetContentType(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            switch (extension)
            {
                case ".html":
                    return "text/html";
                case ".css":
                    return "text/css";
                case ".js":
                    return "application/javascript";
                default:
                    return "application/octet-stream";
            }
        }
    }
}