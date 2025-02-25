// Create web server



const express = require('express');
const app = express();
const port = 3000;

// Set up the template engine
app.set('view engine', 'ejs');

// Set up the static files
app.use(express.static('./public'));

// Fire controllers
commentsController(app);

// Listen to the port
app.listen(port);
console.log('You are listening to port 3000');