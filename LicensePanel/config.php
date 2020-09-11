<?php
$host = "localhost";
$user = "mysql";
$pass = "mysql";
$bdn = "license";

$mysqli = mysqli_connect($host, $user, $pass, $bdn);

if (mysqli_connect_errno()) {
    exit();
}