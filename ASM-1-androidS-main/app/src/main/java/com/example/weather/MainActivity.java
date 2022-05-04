package com.example.weather;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.app.AlertDialog;
import android.os.Bundle;
import android.widget.LinearLayout;
import android.widget.TextView;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {
    private RecyclerView rvHour;
    private TextView tvTem;
    private TextView tvStatus;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tvTem  = (TextView) findViewById(R.id.tvTem);
        tvStatus  = (TextView) findViewById(R.id.tvStatus);

        getHours();

        LinearLayoutManager layoutManager = new LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false);
        rvHour = (RecyclerView) findViewById(R.id.rvHour);
        rvHour.setLayoutManager(layoutManager);

    }
    private void getHours (){
        Retrofit retrofit=new Retrofit.Builder()
                .baseUrl(ApiManager.BASE_URL)
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        ApiManager service=retrofit.create(ApiManager.class);

        service.getHour().enqueue(new Callback<List<Wheather>>() {
            @Override
            public void onResponse(Call<List<Wheather>> call, Response<List<Wheather>> response) {
                if (response.body() == null) return;
                List<Wheather> listWheather = response.body();
                HourAdapter adapter=new HourAdapter(MainActivity.this,listWheather);
                rvHour.setAdapter(adapter);

                Wheather wheather=listWheather.get(0);
                tvTem. setText (wheather.getTemperature().getValue(). intValue()+"o");
                tvStatus.setText(wheather.getIconPhrase());
            }

            @Override
            public void onFailure(Call<List<Wheather>> call, Throwable t) {

            }
        });

    }
}