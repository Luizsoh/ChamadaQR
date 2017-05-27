package com.example.internet.ra_final;

import android.content.DialogInterface;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import java.util.ArrayList;
import java.util.List;

import android.view.View;
import android.widget.*;

public class TelaEventos extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_eventos);

        ListView listaEventos = (ListView)findViewById(R.id.listaEventos);
        ArrayAdapter <String> adaptador;
        List<String> eventos;

        eventos = new ArrayList<String>();

        eventos.add("Evento 1");
        eventos.add("Evento 2");
        eventos.add("Eventos 3");

        adaptador = new ArrayAdapter<String>(TelaEventos.this, android.R.layout.simple_list_item_1,eventos);
        listaEventos.setAdapter(adaptador);
        listaEventos.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                switch (position){

                    case 0: evento1();
                        break;

                }

            }
        });

    }


    private void evento1(){

        //Cria o AlertDialog
        AlertDialog.Builder alerta = new AlertDialog.Builder(this);
        //Colocar o titulo da caixa de dialogo
        alerta.setTitle("Alerta ! ");
        //Coloca a mensagem da caixa
        alerta.setMessage("Deseja marcar presença nesse eventos?");
        //Cria uma ação para o click no item da lista
        alerta.setPositiveButton("Sim", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

                //Da uma mensagem caso clik em SIM
                Toast.makeText(TelaEventos.this, "Aguarde um momento.. Estamos iniciando a leitura do codigo",Toast.LENGTH_SHORT).show();

            }
        });

        //Botão negativo
        alerta.setNegativeButton("Não", null);

        //Mostra o alerta
        alerta.show();
    }

}
