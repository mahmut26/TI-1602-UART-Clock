#include "SAAT.h"
#include "stdbool.h"
#include "stdint.h"
#include "inc/hw_ints.h"
#include "inc/hw_types.h"
#include "inc/hw_memmap.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "LCD.h"







void init_saat_varible(int sa , int dk , int sn){

    saat = sa;
    dakika = dk;
    saniye = sn;

    saati_ekrana_yaz(saat,dakika,saniye);

}
int saat_degiskenlerini_hesapla(int sa , int dk , int sn){

    sn++;
    if (sn==60){
        sn=0;
        dk++;
        if(dk==60){
            dk=0;
            sa++;
            if(sa==24){
                sa=0;
            }
        }
    }
    saat = sa;
    dakika = dk;
    saniye = sn;

    return saat, dakika, saniye;
    //sn++
           //sn=60olmuþþsa
               //dk++ sn=0;
                   //dk=60 olmuþsa
                       //sa++ dk=0,
                           //sa=24 olmuþsa
                               //sa=0


}
void saati_ekrana_yaz(int sa , int dk , int sn){
    int saonlar , sabirler , dkonlar , dkbirler , snonlar, snbirler;
    char sachonlar ,sachbirler , dkchonlar , dkchbirler , snchonlar, snchbirler;

    sabirler = sa%10;
    saonlar = (sa-sabirler)/10;

    dkbirler = dk%10;
    dkonlar = (dk-dkbirler)/10;

    snbirler = sn%10;
    snonlar = (sn-snbirler)/10;

    sachonlar = saonlar + '0';
    sachbirler = sabirler + '0';

    dkchonlar = dkonlar + '0';
    dkchbirler = dkbirler + '0';

    snchonlar = snonlar + '0';
    snchbirler = snbirler + '0';


    Lcd_Satir_Sutuna_Git(1, 7);
    Lcd_Tek_Karakter_Yaz(sachonlar);
    Lcd_Tek_Karakter_Yaz(sachbirler);
    Lcd_Tek_Karakter_Yaz(':');
    Lcd_Tek_Karakter_Yaz(dkchonlar);
    Lcd_Tek_Karakter_Yaz(dkchbirler);
    Lcd_Tek_Karakter_Yaz(':');
    Lcd_Tek_Karakter_Yaz(snchonlar);
    Lcd_Tek_Karakter_Yaz(snchbirler);


    //tek tek bütün karakterleri oluþtur
    //dk = 56
    //dkonlar;
    //dkbirler;
    //dkbirler = dk%10;
    //dkonlar = (dk-dkbirler)/10;
    //int 5 i char 5
    //int 6 yý char 6 yapmam lazým
    //c=a+'0';
}
