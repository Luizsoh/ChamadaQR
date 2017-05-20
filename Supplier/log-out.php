<?php


//fim da sessão
//limpar os arquivos temporarios
//limpa sessions

$local = "temp/";

if(is_dir($local)){
    $diretorio = dir($local);

    while($arquivo = $diretorio->read()){

        if (($arquivo!='.')&&($arquivo!= '..')){
            unlink($local.$arquivo);

        }
    }
    $diretorio->close();
}
else{
    echo "pasta não existe limpeza nao efetuada";
}



session_start();
session_destroy();
Header("Location: login.php");


$_SESSION['loged'] = false;
?>