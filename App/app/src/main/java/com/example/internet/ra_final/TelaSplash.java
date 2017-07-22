package com.example.internet.ra_final;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.*;
import android.os.Handler;

public class TelaSplash extends AppCompatActivity {

    private final int tempoDaSplash = 1500; // Constante que tem o tempo que a tela ficara executando

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_splash);

        new Handler().postDelayed(new Runnable() {// Instancia da Classe Handler para dar o atraso na tela
            @Override
            public void run() {// Metodo sera sempre executado quando o tempoDaSplah acabar.

                Intent abriMainActivity = new Intent(TelaSplash.this,MainActivity.class); // Instancia da classe usada para abrir novas telas
                startActivity(abriMainActivity); // Inicia a activity

                //finaiza a activity de splash
                finish();
            }
        },tempoDaSplash);

    }
}