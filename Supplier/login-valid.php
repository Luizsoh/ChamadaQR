<?php
session_start();

if($_SESSION['loged']== true){
    header("location://index.php");
}





include "connection.php";

if (isset($_POST['login'])) {

    $userName = strip_tags($_POST['username']);
    $pass = strip_tags($_POST['pass']);


}

    ?>