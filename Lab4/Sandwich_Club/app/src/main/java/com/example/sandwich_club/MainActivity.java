package com.example.sandwich_club;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        String jsonText = "{'name':'Мурзик','color':-16777216,'age':9}";

        GsonBuilder builder = new GsonBuilder();
        Gson gson = builder.create();
        Cat murzik = gson.fromJson(jsonText, Cat.class);
        Log.i("GSON", "Имя: " + murzik.name + "\nВозраст: " + murzik.age);

        TextView cat = findViewById(R.id.cat);
        cat.setText("Имя: "+ murzik.name + "\nВозраст " + murzik.age + "\nЦвет: ");
        View cView = findViewById(R.id.cView);
        cView.setBackgroundColor(murzik.color);
    }
}