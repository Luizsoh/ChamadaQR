<?php

ob_start();
session_start();
if (empty($_SESSION['active'])){
    $_SESSION['active']='off';
}
if (empty($_SESSION['loged'])){
    $_SESSION['loged']= false;
}
if ($_SESSION['loged'] == false){
    Header("Location: /login.php");
}
else{
    $nome = $_SESSION['nome'] ;
}
?>


<nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
        <a class="navbar-brand" href="../index.php">Gerenciador de entradas</a>
    </div>

    <div style="margin-left:4%;  " class="navbar-header">
        <label class="navbar-brand evt">Evento:<?php echo $_SESSION['nomeEvento']; ?></label>
        <label class="navbar-brand evt">Data Final Do Evento: <?php  echo $_SESSION['dataFinal'];?></label>
        <label class="navbar-brand evt">Data do Inicio Do Evento: <?php echo $_SESSION['dataDoEvento']; ?> </label>
    </div>
    <!-- Top Menu Items -->
    <ul class="nav navbar-right top-nav">
        <li class="dropdown">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="fa fa-user"></i> <?php echo $nome ?> <b class="caret"></b></a>
            <ul class="dropdown-menu">
                <li>
                    <a href="log-out.php"><i class="fa fa-fw fa-power-off"></i> Log Out</a>
                </li>
            </ul>
        </li>
    </ul>

    <div class="collapse navbar-collapse navbar-ex1-collapse">
        <ul class="nav navbar-nav side-nav">
            <li class="active">
                <a href="index.php"><i class="fa fa-fw fa-dashboard"></i> Inicio</a>
            </li>

            <li>
                <a href="entrada.php"><i class="fa fa-fw fa-table"></i> Entradas</a>
            </li>
            <li>
                <a href="forms.php"><i class="fa fa-fw fa-edit"></i> Forms</a>
            </li>
        </ul>
    </div>
</nav>