<?php

ob_start();


session_start();

if (empty($_SESSION['loged'])) {
    $_SESSION['loged'] = false;
}

if ($_SESSION['loged'] == true) {
    Header("location:index.php");
}





include "connection.php";

date_default_timezone_set('America/Sao_Paulo');
$date = date('y-m-d');


if ($conn) {
    $sql = " SELECT nomeEvento, dataDoEvento,dataFinal,idEvento FROM eventos WHERE dataFinal >= $date  ";
    $dados = mysqli_query($conn, "" . $sql) or die("<br><br><br> serro comando SQL " . $comando);
} else {
    echo "Não foi possivel conectar ao bd";
};
echo "   <html lang=\"en\">
   <head>
     <title>Login</title>
     <meta charset=\"utf-8\">
     <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">
     <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\">
     <link rel=\"stylesheet\" href=\"css\css.css\">
     <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js\"></script>
     <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>
    <script type=\"text/javascript\">
       $(window).on('load',function(){
           $('#myModal').modal('show');
       });
   </script>
   </head>
   <body style=\"background-color: #222222\">   
   <div class=\"container\">   
     <!-- Modal -->
     <div class=\"modal fade\" id=\"myModal\" role=\"dialog\">
       <div class=\"modal-dialog\">       
         <!-- Modal content-->
         <div class=\"modal-content\">
           <div class=\"modal-header\">
          
             <h4 class=\"modal-title\">Login </h4>
           </div>
           <div class=\"modal-body\">
            <form class=\"form-signin\" role=\"form\" action='login.php' method='post'>
            <h2 class=\"form-signin-heading\" contenteditable=\"false\">Digite o usuario e senha</h2>
   
           <input name=\"user\" type=\"text\" class=\"form-control showdown\" placeholder=\"Usuario\" required=\"\" autofocus=\"\" contenteditable=\"false\">         
         <br>         
           <input name=\"pass\" type=\"password\" class=\"form-control showdown\" placeholder=\"Senha\" required=\"\" contenteditable=\"false\">
           <br>
           <div class=\"form-group showdown\">
     <label for=\"sel1\">Evento:</label>
     <select name=\"evento\" class=\"form-control\" id=\"sel1\">
       <option value=\"0\" >Selecionar</option>";
?>

<?php
while ($row = mysqli_fetch_array($dados, MYSQLI_ASSOC)) {
    $cont++;
    echo $cont;

    echo " <option value=" . $row['idEvento'] . " >  " . $row['nomeEvento'] . "Data Final:dataFinal:" . $row['dataFinal'] . "</option>  ";
};


?>"
<?php echo " </select>
   </div>
          <br>
           <button class=\"btn btn-lg btn-primary btn-block new showdown\" type=\"submit\" name='login'>Sign in</button>
       </form>
           </div>
           <div class=\"modal-footer\">
             <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\" >Close</button>
           </div>
         </div>
         
       </div>
     </div>
     
   </div>
   
   </body>
   </html>
   ";
?>


<?php
if (isset($_POST['login'])) {

    $user = $_POST['user'];
    $pass = $_POST['pass'];
    $evento =& $_POST['evento'];

    if (empty($user) || empty($pass) || $evento == 0) {
        echo "<script>alert('Algum dos campos esta vazio');</script>";
    } else {

        if ($conn->connect_error) {
            die("Connection failed: " . $conn->connect_error);
        }

        $comando = "SELECT nomeUsuario, senha FROM usuario WHERE ";
        $comando .= "nomeUsuario='$user' and senha='$pass'";
        $sql = mysqli_query($conn, "" . $comando) or die(" serro comando SQL " . $comando);

        $row = mysqli_num_rows($sql);

        if ($row == 0) {

            echo "<script>alert('Usuário/Senha inválidos!');</script>";

        } else {
            if ($conn) {
                $sql = " SELECT nomeEvento, dataDoEvento,dataFinal,idEvento FROM eventos WHERE idEvento = " . $evento . "  ";
                $dados = mysqli_query($conn, "" . $sql) or die("<br><br><br> serro comando SQL " . $comando);
                $row = mysqli_fetch_array($dados, MYSQLI_ASSOC);


                    $_SESSION['nomeEvento'] = $row['nomeEvento'];
                    $_SESSION['dataFinal'] = $row['dataFinal'];
                    $_SESSION['dataDoEvento'] = $row['dataDoEvento'];


                    $_SESSION['evento'] = $evento;
                    $_SESSION['loged'] = true;
                    $_SESSION['nome'] = $user;

                Header("/Location:index.php");

            }

        }
    }
}

?>