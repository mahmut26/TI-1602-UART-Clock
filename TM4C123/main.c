#include <stdint.h>
#include <stdbool.h>
#include "inc/tm4c123gh6pm.h"
#include "inc/hw_memmap.h"
#include "inc/hw_types.h"
#include "driverlib/sysctl.h"
#include "driverlib/debug.h"
#include "driverlib/gpio.h"
#include "driverlib/pin_map.h"
#include "driverlib/interrupt.h"
#include "driverlib/timer.h"
#include "driverlib/adc.h"
#include "driverlib/uart.h"
#include "LCD.h"
void Timer0IntHandler(void);
void adcintt(void);
void serikesme(void);
int a=0;
int b=0;
int c=0;
int d=0;
int e=0;
int f=0;
int g=0;
int h=0;
int ikinokta=58;
char gelenveri;
uint32_t ui32Period;
uint32_t ui32ADC0Value[4];
volatile double ui32TempAvg;
volatile double ui32TempValueC;
uint32_t saat[8];

int main(void)

{
    SysCtlClockSet(SYSCTL_SYSDIV_4|SYSCTL_USE_PLL|SYSCTL_XTAL_16MHZ|SYSCTL_OSC_MAIN);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOE);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_ADC0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_TIMER0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);

    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);

    UARTConfigSetExpClk(UART0_BASE, SysCtlClockGet(), 115200,(UART_CONFIG_WLEN_8 | UART_CONFIG_STOP_ONE | UART_CONFIG_PAR_NONE));

    IntMasterEnable();

    IntEnable(INT_TIMER0A);
    TimerConfigure(TIMER0_BASE, TIMER_CFG_PERIODIC);
    TimerIntEnable(TIMER0_BASE, TIMER_TIMA_TIMEOUT);
    ui32Period = SysCtlClockGet();
    TimerLoadSet(TIMER0_BASE, TIMER_A, ui32Period -1);
    TimerIntRegister(TIMER0_BASE, TIMER_A, Timer0IntHandler);

    ADCIntEnable(ADC0_BASE,1);
    IntEnable(INT_ADC0SS1);
    GPIOPinTypeADC(GPIO_PORTE_BASE, GPIO_PIN_2);
    ADCSequenceConfigure(ADC0_BASE, 1, ADC_TRIGGER_PROCESSOR, 0);
    ADCSequenceStepConfigure(ADC0_BASE, 1, 0, ADC_CTL_CH1);
    ADCSequenceStepConfigure(ADC0_BASE, 1, 1, ADC_CTL_CH1);
    ADCSequenceStepConfigure(ADC0_BASE, 1, 2, ADC_CTL_CH1);
    ADCSequenceStepConfigure(ADC0_BASE,1, 3, ADC_CTL_CH1|ADC_CTL_IE|ADC_CTL_END);
    ADCSequenceEnable(ADC0_BASE, 1);
    ADCIntRegister(ADC0_BASE, 1,adcintt);

    IntEnable(INT_UART0);
    UARTIntEnable(UART0_BASE, UART_INT_RX | UART_INT_RT);
    UARTIntRegister(UART0_BASE, serikesme);

    Lcd_ilk_ayarlar();
    TimerEnable(TIMER0_BASE, TIMER_A);
    ADCProcessorTrigger(ADC0_BASE, 1);


    while(1)
    {

    }
}

void Timer0IntHandler(void)

{
//    TimerIntClear(TIMER0_BASE, TIMER_TIMA_TIMEOUT);
//
//    Lcd_Satir_Sutuna_Git(1,8);
//    Lcd_Tek_Karakter_Yaz(48+a);
//    Lcd_Satir_Sutuna_Git(1,7);
//    Lcd_Tek_Karakter_Yaz(48+b);
//    Lcd_Satir_Sutuna_Git(1,6);
//    Lcd_Tek_Karakter_Yaz(ikinokta);
//    Lcd_Satir_Sutuna_Git(1,5);
//    Lcd_Tek_Karakter_Yaz(48+c);
//    Lcd_Satir_Sutuna_Git(1,4);
//    Lcd_Tek_Karakter_Yaz(48+d);
//    Lcd_Satir_Sutuna_Git(1,3);
//    Lcd_Tek_Karakter_Yaz(ikinokta);
//    Lcd_Satir_Sutuna_Git(1,2);
//    Lcd_Tek_Karakter_Yaz(48+e);
//    Lcd_Satir_Sutuna_Git(1,1);
//    Lcd_Tek_Karakter_Yaz(48+f);
//    a++;
//    if (9<a)
//    {
//        a=0;
//        b++;
//    }
//    if (5<b)
//    {
//        b=0;
//        c++;
//    }
//    if( 9<c)
//    {
//        c=0;
//        d++;
//    }
//    if (5<d)
//    {
//        d=0;
//        e++;
//    }
//    if (9<f)
//    {
//        e=0;
//        f++;
//    }
//    if (e==4 & f==2)
//    {
//        e=0;
//        f=0;
//    }

}

void adcintt(void)
{
    ADCIntClear(ADC0_BASE, 1);
    ADCSequenceDataGet(ADC0_BASE, 1, ui32ADC0Value);
    ui32TempAvg = (ui32ADC0Value[0] + ui32ADC0Value[1] + ui32ADC0Value[2] + ui32ADC0Value[3])/4;
    ui32TempValueC = (ui32TempAvg/ 4096.0) * 330;
    g=ui32TempValueC/10;
    h=(int)ui32TempValueC%10;
    ADCProcessorTrigger(ADC0_BASE, 1);

    TimerIntClear(TIMER0_BASE, TIMER_TIMA_TIMEOUT);

       Lcd_Satir_Sutuna_Git(1,8);
       Lcd_Tek_Karakter_Yaz(48+a);
       Lcd_Satir_Sutuna_Git(1,7);
       Lcd_Tek_Karakter_Yaz(48+b);
       Lcd_Satir_Sutuna_Git(1,6);
       Lcd_Tek_Karakter_Yaz(ikinokta);
       Lcd_Satir_Sutuna_Git(1,5);
       Lcd_Tek_Karakter_Yaz(48+c);
       Lcd_Satir_Sutuna_Git(1,4);
       Lcd_Tek_Karakter_Yaz(48+d);
       Lcd_Satir_Sutuna_Git(1,3);
       Lcd_Tek_Karakter_Yaz(ikinokta);
       Lcd_Satir_Sutuna_Git(1,2);
       Lcd_Tek_Karakter_Yaz(48+e);
       Lcd_Satir_Sutuna_Git(1,1);
       Lcd_Tek_Karakter_Yaz(48+f);
       a++;
       if (9<a)
       {
           a=0;
           b++;
       }
       if (5<b)
       {
           b=0;
           c++;
       }
       if( 9<c)
       {
           c=0;
           d++;
       }
       if (5<d)
       {
           d=0;
           e++;
       }
       if (9<f)
       {
           e=0;
           f++;
       }
       if (e==4 & f==2)
       {
           e=0;
           f=0;
       }

    Lcd_Satir_Sutuna_Git(1,13);
    Lcd_Tek_Karakter_Yaz(48+g);
    Lcd_Satir_Sutuna_Git(1,14);
    Lcd_Tek_Karakter_Yaz(48+h);
    Lcd_Satir_Sutuna_Git(1,15);
    Lcd_Tek_Karakter_Yaz(223);
    Lcd_Satir_Sutuna_Git(1,16);
    Lcd_Tek_Karakter_Yaz(67);
}
void serikesme(void)
{
    uint32_t ui32Status;
    ui32Status = UARTIntStatus(UART0_BASE, true);
    UARTIntClear(UART0_BASE, ui32Status);

    while(UARTCharsAvail(UART0_BASE))
    {
        gelenveri=UARTCharGet(UART0_BASE);
        if (gelenveri=='*')
        {
            Lcd_Temizle();
            int j=1;
            while(UARTCharsAvail(UART0_BASE))
            {
                gelenveri=UARTCharGet(UART0_BASE);
                UARTCharPut(UART0_BASE, gelenveri);
                Lcd_Satir_Sutuna_Git(2, j);
                Lcd_Tek_Karakter_Yaz(gelenveri);
                j++;
            }
        }
        if (gelenveri=='#')
        {
            int i=0;
            while(UARTCharsAvail(UART0_BASE))
            {
                saat[i]=UARTCharGet(UART0_BASE);
                i++;
            }
            f=saat[0]-48;
            e=saat[1]-48;
            ikinokta=saat[2];
            d=saat[3]-48;
            c=saat[4]-48;
            ikinokta=saat[5];
            b=saat[6]-48;
            a=saat[7]-48;

        }
        if (gelenveri=='&')
        {
            UARTCharPut(UART0_BASE, 48+g);
            UARTCharPut(UART0_BASE, 48+h);

         }
    }
}
