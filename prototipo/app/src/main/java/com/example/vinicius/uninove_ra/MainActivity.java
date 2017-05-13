package com.example.vinicius.uninove_ra;

import android.content.Intent;
import android.support.annotation.ColorRes;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.*;
import android.support.design.widget.Snackbar;


public class MainActivity extends AppCompatActivity implements  View.OnClickListener{

    private Toolbar sToolbar;
    private Button btnEntrar;
    private EditText txtRa;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //ToolBar
        sToolbar = (Toolbar)findViewById(R.id.toolbar01);
        sToolbar.setTitle("Uninove - RA");
        sToolbar.setSubtitle(" Fabrica de app - Uninove");

        setSupportActionBar(sToolbar);

        //Encontra os Views
        btnEntrar = (Button)findViewById(R.id.btnEntrar);
        txtRa = (EditText)findViewById( R.id.txtRa);

        //Adicionando o metodo de click no botao
        btnEntrar.setOnClickListener(this);
    }

    //Metodo do ouvinte de "toque"
    @Override
    public void onClick(View v) {
        // Verifica de o EditText está vazio
        if(txtRa.length() == 0){

          //Executa a mensagem
            Snackbar s;
            s = Snackbar.make(v,"O CAMPO RA ESTÁ VAZIO !!", Snackbar.LENGTH_LONG);
            s.show();

        }else{//Caso contrario abre a tela de eventos

            Intent novaTela =  new Intent(MainActivity.this,TelaEventos.class);
            startActivity(novaTela);
        }
    }
}
