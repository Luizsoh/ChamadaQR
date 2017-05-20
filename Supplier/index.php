



<?php

include ("header/header.php");
include ("menu/menu.php");
?>



<div id="wrapper"> 	
        <div id="page-wrapper">
            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                        <h3 class="page-header">
							QRCode
                        </h3>
                        <ol class="breadcrumb">

                            <li class="active">
                                <i class="fa fa-table"></i> Inicio
                            </li>
                        </ol>
                    </div>
                  <label style="" >  <form action="index.php" method="post">
                        <input type="submit" value="Ativar/Desativar" name="active">
                    </form><hr/></label>
                </div >
                <div align="center">
                <?php

                //função do botao de ativar ou desativar
                if (isset($_POST['active'])){


                //caso o botao seja acionado com a session ativa
                //ele desativa e vice e versa
                if ($_SESSION['active'] == 'on') {
                    $_SESSION['active'] ='off';
                    echo '<META HTTP-EQUIV="REFRESH" CONTENT="7000">';

                }
                else{
                    $_SESSION['active'] ='on';
                   echo '<META HTTP-EQUIV="REFRESH" CONTENT="7">';

                }
                }

                //ativa execução e criação de qr code
                if ($_SESSION['active'] == 'on'){

                    //atualização da pagina a cada 7 segundos
                echo '<META HTTP-EQUIV="REFRESH" CONTENT="7">';


                //pega o id do usuario logado
                $id   = $_SESSION['nome'];


                    //declara data online
                date_default_timezone_set('America/Sao_Paulo');
                $date = date('d/m/y-H:i:s');

                $data = date('d/m/y');

                $hora = date('H:i:s');

                //string do Qr Code
                $string = $_SESSION['nome'].$date.$_SESSION['nomeEvento'].$id;


                ///////////////////////////////////////////Criado do qr Code///////////////////////////////////////////////

                //set it to writable location, a place for temp generated PNG files
                $PNG_TEMP_DIR = dirname(__FILE__).DIRECTORY_SEPARATOR.'temp'.DIRECTORY_SEPARATOR;

                //seleciona pasta para
                //exporta a imagem para a pasta de arquivos temporarios
                //essa imagem e executada no html
                $PNG_WEB_DIR = 'tempp/';

                //chama função de criação
                include "Gerador Qr/qrlib.php";

                //ofcourse we need rights to create temp dir
                if (!file_exists($PNG_TEMP_DIR))
                    mkdir($PNG_TEMP_DIR);

                $filename = $PNG_TEMP_DIR.'test.png';

               // niveis da correção de erro('L','M','Q','H')
                    $errorCorrectionLevel = "m";

                //define tamanho do qr code
                   $matrixPointSize = 10;
                //string de saida do qr code
                    $data = base64_encode($string);

                    $_SESSION['dell']="";
                    $_SESSION['dell']=base64_encode($data.'|'.$errorCorrectionLevel.'|'.$matrixPointSize).'.png';

                    // user data
                    $filename = $PNG_TEMP_DIR.base64_encode($data.'|'.$errorCorrectionLevel.'|'.$matrixPointSize).'.png';
                    QRcode::png($data, $filename, $errorCorrectionLevel, $matrixPointSize, 2);

                //display generated file
                echo '<img src="'.$PNG_WEB_DIR.basename($filename).'" /><hr/>';
                echo "Codificado =  ".$data."<br>";
                echo "Decodificado = ".base64_decode($data);

                //executa a limpeza do arquivo

                echo $_SESSION['dell'];
                   }  ?>
                </div>
            </div>
        </div>




</div>
	
    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Morris Charts JavaScript -->
    <script src="js/plugins/morris/raphael.min.js"></script>
    <script src="js/plugins/morris/morris.min.js"></script>
    <script src="js/plugins/morris/morris-data.js"></script>
<?php include("header/bottom.php") ?>


