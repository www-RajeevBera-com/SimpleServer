using System.Net;

class Program
{
    static void Main(string[] args)
    {
        HttpListener listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:8080/");
        listener.Start();
        Console.WriteLine("Listening for connections on http://localhost:8080/");
        while (true)
        {
            HttpListenerContext context = listener.GetContext(); // Get the incoming request
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            // Write a response back to the client
            string responseString = "<html><body><h1>Hello, World!</h1></body></html>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();


        }
    }
}
