<?php
$host = "localhost";
$user = "bd_user";
$pass = "bd_password";
$bdn = "bd_name";

$mysqli = mysqli_connect($host, $user, $pass, $bdn);

if (mysqli_connect_errno()) {
    exit();
}
