<?php
// Check for empty fields
/*if(empty($_POST['name'])      ||
   empty($_POST['email'])     ||
   empty($_POST['phone'])     ||
   empty($_POST['message'])   ||
   !filter_var($_POST['email'],FILTER_VALIDATE_EMAIL))
   {
   echo "No arguments Provided!";
   return false;
   }
 */  
/*
$name = strip_tags(htmlspecialchars($_POST['name']));
$email_address = strip_tags(htmlspecialchars($_POST['email']));
$phone = strip_tags(htmlspecialchars($_POST['phone']));
$message = strip_tags(htmlspecialchars($_POST['message']));
*/

/*$name = "name";
$email_address = "email@gmail.com";
$phone = "999130638";
$message = "menssage";

$headers = "MIME-Version: 1.0\r\n"; 
$headers .= "Content-type: text/html; charset=iso-8859-1\r\n"; 
   
// Create the email and send the message
$to = 'heber.daniel.ramos.mendoza@gmail.com'; 
// Add your email address inbetween the '' replacing yourname@yourdomain.com - This is where the form will send a message to.
$email_subject = "Website Contact Form: ";
$email_body = "Prueba"; 
// This is the email address the generated message will be from. We recommend using something like noreply@yourdomain.com.
$headers .= "From: Geeky Theory heber.ramos.mendoza@gmail.com \r\n";   

mail($to,$email_subject,$email_body,$headers);
return true; */

require 'vendor/autoload.php'; // If you're using Composer (recommended)
// Comment out the above line if not using Composer
// require("./sendgrid-php.php"); 
// If not using Composer, uncomment the above line
echo "Iniciamos";
$email = new \SendGrid\Mail\Mail();

echo "Primero";

$email->setFrom("heber.ramos.mendoza@gmail.com", "Example User 1");
echo "Segundo";

$email->setSubject("Sending with SendGrid is Fun");
$email->addTo("heber.daniel.ramos.mendoza@gmail.com", "Example User 2");
/*$email->addContent("text/html", "and easy to do anywhere, even with PHP - HEROKU");*/
$email->addContent(
    "text/html", "<strong>and easy to do anywhere, even with PHP - HEROKU</strong>"
);
echo "Tercero";

/*$sendgrid = new \SendGrid('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');
try {
    $response = $sendgrid->send($email);
    print $response->statusCode() . "\n";
    print_r($response->headers());
    print $response->body() . "\n";
} catch (Exception $e) {
    echo 'Caught exception: ',  $e->getMessage(), "\n";
} */    
?>