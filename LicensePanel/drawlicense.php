<?php
include ('config.php');

$pass = $_GET['p'];
$date = $_GET['date'];
$HWID = $_GET['hwid'];
$del = $_GET['del'];

$ps = "your password";

if($pass == $ps)
{
    echo "OK";
    if ($del == 1){
        /** @var TYPE_NAME $mysqli */
        mysqli_query($mysqli, "DELETE FROM `userinfo` WHERE `hwid`='".mysqli_real_escape_string($mysqli, $HWID)."'");
    }
    else {
        /** @var TYPE_NAME $mysqli */
        $check = mysqli_query($mysqli, "SELECT * FROM `userinfo` WHERE `hwid`='" . mysqli_real_escape_string($mysqli, $HWID) . "'");
        if (mysqli_num_rows($check) > 0) {
            exit();
        }
        mysqli_query($mysqli, "INSERT INTO `userinfo` SET `hwid`='" . mysqli_real_escape_string($mysqli, $HWID) . "', `date`='" . mysqli_real_escape_string($mysqli, $date) . "'");
    }
}
else { exit(); }