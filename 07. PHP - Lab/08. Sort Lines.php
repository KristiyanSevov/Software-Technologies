<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PHP Lab</title>

</head>
<body>

<?php
$sorted = "";
if (isset($_GET["lines"])) {
    $lines = explode("\n", $_GET["lines"]);
    $lines = array_map('trim', $lines);
    sort($lines, SORT_STRING);
    $sorted = implode("\n", $lines);
}
?>

<form>
    <textarea rows="10" name="lines"><?= $sorted ?></textarea> <br />
    <input type="submit" value="Sort" />
</form>

</body>
</html>