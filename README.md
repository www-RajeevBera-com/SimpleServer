# SimpleServer Solution

## Overview
The **SimpleServer** solution contains two main components:
1. **SimpleServeGUI**: A Windows Forms-based application that allows users to select a path for their static website, choose a port, and launch the web server with a simple graphical interface.
2. **SimpleServerConsole**: A console-based application that hosts a simple HTTP server to serve static files such as HTML, CSS, and JavaScript.

The solution also includes a test site with some sample HTML, CSS, and JavaScript files that can be used to test the server functionality.

## Features
- **GUI Web Server Launcher**: Launch a web server using a graphical interface where you can select your website folder and specify the port number.
- **Console Web Server**: A basic HTTP server to serve static files and provide insight into how web servers work.
- **Test Site**: A basic test website containing HTML, CSS, and JavaScript to use with the server.

## Video Tutorial

Watch the full video tutorial on YouTube:
[Watch here](https://www.youtube.com/watch?v=ZeRkgOmsmlE)



## Test Site
The `test-site` folder includes a simple HTML site to demonstrate the web server functionality. It consists of four files:
- `index.html`
- `about.html`
- `style.css`
- `script.js`

You can use this site or add your own files to the `test-site` folder to serve other static content.

## How to Use
### 1. Build and Run
After cloning the repository, open the **SimpleServer** solution in Visual Studio.

1. Build the solution.
2. Run the **SimpleServeGUI** project, which will open a Windows Forms interface.

### 2. Launch the Server
The interface will prompt you to:
- **Choose a path** for your site (by default, the test site is included in the `test-site` folder).
- **Set the port** for your server (default is `8080`, but you can set it to any available port like `80` or `12345`).

Once you click the **Launch** button, the web server will start, and your website will open in your default browser.

## Test Site Example
The test site includes:
- **HTML**: Basic structure with two pages (`index.html` and `about.html`).
- **CSS**: Styling to improve the layout of the pages.
- **JavaScript**: Adds simple interactivity (button click functionality).

Feel free to modify these files or replace them with your own content.

## Licensing
The solution is published under the MIT License, meaning you can use it freely and legally for any purpose. You can:
- Make your own repository.
- Copy the code.
- Use it in your CV.
- Build your portfolio.
- Modify and enhance it as you like!

## Contributing
Contributions are welcome! Feel free to submit pull requests to improve the project. Let’s make it better together.

## Thank You
I hope you enjoy using this project and find it helpful in your development journey. If you like it, don't forget to enhance it and share your own improvements.

Thank you for watching and using the SimpleServer solution!
