#include "DFRobot_EC.h" //ec
#include <EEPROM.h> //ec
#include <OneWire.h> //temp
#include <DallasTemperature.h> //temp

#define ONE_WIRE_BUS 5 //temp in digital pin 5
#define EC_PIN A0 //ec
#define TurbidityPin A3 // Turbidity
//ph
#define SensorPin A5            //pH meter Analog output to Arduino Analog Input 0
#define Offset 0.00            //deviation compensate
#define LED 13
#define samplingInterval 20
#define printInterval 800
#define ArrayLenth  40    //times of collection
int pHArray[ArrayLenth];   //Store the average value of the sensor feedback
int pHArrayIndex=0; 

OneWire oneWire(ONE_WIRE_BUS);

DallasTemperature sensors(&oneWire);

 float Celcius=0;
 float Fahrenheit=0;

float voltage,ecValue,temperature = 20;
DFRobot_EC ec;

void setup()
{
  pinMode(LED,OUTPUT); //ph
  Serial.begin(115200);  
  ec.begin(); //for EC
  sensors.begin(); //for tempareture
}

void loop()
{
  //for ph
    static unsigned long samplingTime = millis();
    static unsigned long printTime = millis();
    static float pHValue,voltage;
    String data;
    
    //PH
    if(millis()-samplingTime > samplingInterval)
    {
      pHArray[pHArrayIndex++]=analogRead(SensorPin);
      if(pHArrayIndex==ArrayLenth)pHArrayIndex=0;
      voltage = avergearray(pHArray, ArrayLenth)*5.0/1024;
      pHValue = 3.5*voltage+Offset;
      samplingTime=millis();
    }
    if(millis() - printTime > printInterval)   //Every 800 milliseconds, print a numerical, convert the state of the LED indicator
    {
      voltage = analogRead(EC_PIN)/1024.0*5000;  // read the voltage
      temperature = readTemperature();  // read your temperature sensor to execute temperature compensation
      ecValue =  ec.readEC(voltage,temperature);  // convert voltage to EC with temperature compensation
      
      data = String(temperature) + "@" + String(ecValue);
      
      float turbidity = GetTurbidity();
      digitalWrite(LED,digitalRead(LED)^1);
      printTime=millis();
      
      data += "@" + String(pHValue) + "@" + String(turbidity);
      Serial.println(data); //sending data to the serial port
    }
    ec.calibration(voltage,temperature);  // calibration process by Serail CMD
  //done
}

float GetTurbidity()
{
    float turbidity;
    float volt = 0;
    for(int i=0; i<800; i++)
    {
        volt += ((float)analogRead(TurbidityPin)/1023)*5;
    }
    volt = volt/800;
    volt = round_to_dp(volt,6);
    if(volt>4.200246) // for x = 4.200246, the equation become 0
    {
      turbidity = 0;
    }
    else if( volt < 2.5)
    {
      turbidity = 3000;
    }
    else
    {
      turbidity = -1120.4*square(volt)+5742.3*volt-4352.9;
    }
    return turbidity;
}
float round_to_dp( float in_value, int decimal_place )
{
  float multiplier = powf( 10.0f, decimal_place );
  in_value = roundf( in_value * multiplier ) / multiplier;
  return in_value;
}

double avergearray(int* arr, int number){
  int i;
  int max,min;
  double avg;
  long amount=0;
  if(number<=0){
    Serial.println("Error number for the array to avraging!/n");
    return 0;
  }
  if(number<5){   //less than 5, calculated directly statistics
    for(i=0;i<number;i++){
      amount+=arr[i];
    }
    avg = amount/number;
    return avg;
  }else{
    if(arr[0]<arr[1]){
      min = arr[0];max=arr[1];
    }
    else{
      min=arr[1];max=arr[0];
    }
    for(i=2;i<number;i++){
      if(arr[i]<min){
        amount+=min;        //arr<min
        min=arr[i];
      }else {
        if(arr[i]>max){
          amount+=max;    //arr>max
          max=arr[i];
        }else{
          amount+=arr[i]; //min<=arr<=max
        }
      }//if
    }//for
    avg = (double)amount/(number-2);
  }//if
  return avg;
}

float readTemperature()
{
  //add your code here to get the temperature from your temperature sensor
  sensors.requestTemperatures(); 
  Celcius=sensors.getTempCByIndex(0);
  Fahrenheit=sensors.toFahrenheit(Celcius);

  return Celcius;
}
