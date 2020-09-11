<?php
include ('config.php');

$hwid = $_GET['hwid'];

/** @var TYPE_NAME $mysqli */
$check =  mysqli_query($mysqli, "SELECT * FROM `userinfo`");

while ($row = mysqli_fetch_row($check))
{
    if($row[0] == $hwid)
    {
        echo $row[1];
        break;
    }
}
?>