
#include <MFRC522.h>

#include <Servo.h>

#include <SPI.h>

//RFİD YE BAĞLANTI YAPTIĞIMIZ PİNLERİ BELİRLİYORUZ.
int SS_PIN =10;
int RST_PIN= 9;
int SS_PIN2 =7;
int RST_PIN2= 3;
int ServoPIN = 8; //servoya sinyal göndericeğimiz pini 8 olarak belirledik.Bu bağlantıyıda zaten sağladık.
byte buzzerPin=2;
bool durum=true;

Servo motor; //servo motoru kullanabilmek için motor isminde bir servo nesnesi tanımlandı
MFRC522 rfid(SS_PIN,RST_PIN); //rfid kartını kullanabilmemiz için tanımlamaları yapıldı.
MFRC522 rfid2(SS_PIN2,RST_PIN2);
byte Id[4] = {82, 74 ,135 ,213 }; 
byte kart2[4];
byte num[4];
void setup() {
  pinMode(buzzerPin,OUTPUT);
  Serial.begin(9600); //serial haberleşmeyi başlatıyoruz.
  SPI.begin(); //arduino ve rfid kartının haberleşmesi için SPI haberleşmeyi başlatıyorum.
  rfid.PCD_Init();
  rfid2.PCD_Init();
  motor.attach(ServoPIN);//servo motoru hangi pine bağladığımızı belirtiyoruz.
  
}

void loop() {

   if (! rfid2.PICC_IsNewCardPresent()) 
   {return;}
   if (! rfid2.PICC_ReadCardSerial()) 
   { return;}
  if(durum==true){
    
       if (rfid2.uid.uidByte[0] == Id[0] && rfid2.uid.uidByte[1] == Id[1] && rfid2.uid.uidByte[2] == Id[2] && rfid2.uid.uidByte[3] == Id[3])
       {
        
        digitalWrite(buzzerPin,1);
        delay(500);
       }
       else
       {
        Serial.println("Olumsuz");
       }
   }


   if (! rfid.PICC_IsNewCardPresent()) 
   {return;}
   if (! rfid.PICC_ReadCardSerial()) 
   { return;}
   
  if(Serial.available()){ //eğer kontenjan kalmamış ise gelen değer durumu false a düşürcek böylece servo motor dönmeyecek ve kapı açılmayack.
    char gelen=Serial.read();
    if(gelen=='a'){
      
        motor.write(0);
        durum=false;
      }
     if(gelen=='b'){
        
        kart2[0]=num[0];
        kart2[1]=num[1];
        kart2[2]=num[2];
        kart2[3]=num[3];
      }
    }
    
   if(durum==true){
    
       if (rfid.uid.uidByte[0] == Id[0] && rfid.uid.uidByte[1] == Id[1] && rfid.uid.uidByte[2] == Id[2] && rfid.uid.uidByte[3] == Id[3])
       {
        
        digitalWrite(buzzerPin,1);
        Serial.println("Giris Yapildi"); 
        //ekranaYazdir();
        motor.write(180);
        delay(2000);
        motor.write(0);
        Serial.println("Kapi kapandi");
        digitalWrite(buzzerPin,0);
        //delay(1000);

       }
       else if(rfid.uid.uidByte[0] == kart2[0] && rfid.uid.uidByte[1] == kart2[1] && rfid.uid.uidByte[2] == kart2[2] && rfid.uid.uidByte[3] == kart2[3])
       {
        
        digitalWrite(buzzerPin,1);
        Serial.println("Giris Yapildi"); 
        //ekranaYazdir();
        motor.write(180);
        delay(2000);
        motor.write(0);
        Serial.println("Kapi kapandi");
        digitalWrite(buzzerPin,0);
        //delay(1000);
        
        
        }
        else
        {
         Serial.println("Yetkisiz Kart");
         ekranaYazdir();
        }    
    }
 durum=true;
 rfid.PICC_HaltA();    
  }
    
void ekranaYazdir(){
  String a;
  // Serial.print("ID NUMARASİ: ");
  for(int sayac = 0; sayac< 4; sayac++)
  {
    num[sayac]= rfid.uid.uidByte[sayac];
    a+=num[sayac];
    a+=" ";

  }
  Serial.println(a);
}
