package com.Foodiy.foodiymap;

import android.Manifest;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Bundle;
import android.provider.Settings;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.annotation.RequiresPermission;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.model.MarkerOptions;
import com.naver.maps.geometry.LatLng;
import com.naver.maps.map.MapView;
import com.naver.maps.map.NaverMap;
import com.naver.maps.map.OnMapReadyCallback;
import com.naver.maps.map.overlay.LocationOverlay;
import com.naver.maps.map.overlay.Marker;

public class MapsNaverActivity extends Activity implements OnMapReadyCallback  {

    private MapView mapView;
    private NaverMap naverMap;
    Marker marker = new Marker();


    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);

        setContentView(R.layout.naver_activity_maps);

        //위치파악 허용
        if(!checkLocationServiceStatus()){
            showDialogForLocationServiceSetting();
        }else{
            checkRunTimePermission();
        }

        mapView = findViewById(R.id.map);   //맵을 띄운다


        View.OnClickListener listner = new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {

            }
        };
        ImageView btnMyLocation = (ImageView) findViewById(R.id.notFixedGps);
        btnMyLocation.setOnClickListener(listner);

    }

    private void checkRunTimePermission() {
        int hasFineLocationPermission = ContextCompat.checkSelfPermission(MapsNaverActivity.this,
                Manifest.permission.ACCESS_FINE_LOCATION);
        int hasCoarseLocationPermission = ContextCompat.checkSelfPermission(MapsNaverActivity.this,
                Manifest.permission.ACCESS_COARSE_LOCATION);

        if(hasFineLocationPermission == PackageManager.PERMISSION_GRANTED &&
        hasCoarseLocationPermission == PackageManager.PERMISSION_GRANTED){
        //이다음꺼는 설정이 어떻게.. 안되네...
        }
    }

    @Override
    public void onMapReady(@NonNull NaverMap naverMap) {

        marker.setPosition(new LatLng(37.5670135, 126.9783740));
        marker.setMap(naverMap);
    }

    private void showDialogForLocationServiceSetting(){
        AlertDialog.Builder builder = new AlertDialog.Builder(MapsNaverActivity.this);
        builder.setTitle("위치 서비스 비활성화");
        builder.setMessage("앱을 사용하기 위해서는 위치 서비스가 필요합니다");
        builder.setCancelable(true);
        builder.setPositiveButton("설정", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                Intent callGPSSettingIntent
                        = new Intent(Settings.ACTION_LOCATION_SOURCE_SETTINGS);
            }
        });
        builder.setNegativeButton("취소", new DialogInterface.OnClickListener(){
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });
        builder.create().show();
    }

    public boolean checkLocationServiceStatus(){
        LocationManager locationManager = (LocationManager) getSystemService(LOCATION_SERVICE);

        return locationManager.isProviderEnabled(LocationManager.GPS_PROVIDER)
                || locationManager.isProviderEnabled(LocationManager.NETWORK_PROVIDER);

    }
}

