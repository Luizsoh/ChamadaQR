package com.example.internet.ra_final;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.*;
import android.view.View;
import android.widget.*;
import android.support.design.widget.Snackbar;


public class MainActivity extends AppCompatActivity implements View.OnClickListener {

   private Button btn_entrar;
    private  EditText txt_ra;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);



        btn_entrar = (Button)findViewById(R.id.btnEntrar);
        txt_ra = (EditText)findViewById(R.id.txt_Ra);

        btn_entrar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {

        if(txt_ra.length() == 0 ){

            Snackbar s;
            s = Snackbar.make(v,"O CAMPO RA ESTÁ VAZIO !!", Snackbar.LENGTH_LONG);
            s.show();

        }else{

            Intent abreTela = new Intent(this,TelaEventos.class);
            startActivity(abreTela);

            //
            finish();

        }

    }
}
