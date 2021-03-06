<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
    <link rel="stylesheet" href="css/styles.css">

    <title>Ella's</title>
</head>

<body>
<?php include 'view/header.php';?>

    <header class="reportshowcase">
        <div class="container showcase-inner">
            <div class="textblock">
                <h1>Swedish Municipality Schools</h1>
                <div id="content">
                    <p style="text-align: center;">Lets fetch and display some data. Click refresh to display the data! </p>
                    <button class="btn" onclick="CreateTableFromJSON()">Refresh</button>
                    <br>
                    <br>
                    <table id="showData"></table>
                </div>
            </div>
        </div>
    </header>
    <script>
        function CreateTableFromJSON() {

            fetch('data/1081.json')
                .then((response) => {
                    return response.json();
                })
                .then((myJson) => {
                    console.log(myJson);
                    let schools = myJson.Skolenheter

                    var col = [];
                    for (var i = 0; i < schools.length; i++) {
                        for (var key in schools[i]) {
                            if (col.indexOf(key) === -1) {
                                col.push(key);
                            }
                        }
                    }

        
                    var table = document.createElement("table");

      
                    var tr = table.insertRow(-1); 

                    for (var i = 0; i < col.length; i++) {
                        var th = document.createElement("th"); 
                        th.innerHTML = col[i];
                        tr.appendChild(th);
                    }
                    for (var i = 0; i < schools.length; i++) {

                        tr = table.insertRow(-1);

                        for (var j = 0; j < col.length; j++) {
                            var tabCell = tr.insertCell(-1);
                            tabCell.innerHTML = schools[i][col[j]];
                        }
                    }
                    var divContainer = document.getElementById("showData");
                    divContainer.innerHTML = "";
                    divContainer.appendChild(table);

                });
        }
    </script>
    <?php include 'view/footer.php';?>
</body>

</html>