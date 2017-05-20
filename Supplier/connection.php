<?php

$servername = "robb0161.publiccloud.com.br"; //ip para caonexão
$username = "fabri_ra"; //nome do usuario com a cesso ao banco de dados
$password = "Yocf968!"; //senha do usuario
$database = "fabricaapp_ra"; //Nome do banco de dados

$conn = new mysqli($servername, $username, $password,$database);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

?>