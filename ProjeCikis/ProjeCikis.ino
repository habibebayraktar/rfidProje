
#include <MFRC522.h>

#include <Servo.h>

#include <SPI.h>

//RFİD YE BAĞLANTI YAPTIĞIMIZ PİNLERİ BELİRLİYORUZ.
int SS_PIN =10;
int RST_PIN= 9;
int ServoPIN = 8; //servoya sinyal göndericeğimiz pini 8 olarak belirledik.Bu bağlantıyıda zaten sağladık.

Servo motor2; //servo motoru kullanabilmek için motor isminde bir servo nesnesi tanımlandı
MFRC522 rfid2(SS_PIN,RST_PIN); //rfid cikis karti
byte Id[4] = {82, 74 ,135 ,213 }; 



void setup() {
  Serial.begin(9600); //serial haberleşmeyi başlatıyoruz.
  SPI.begin(); //arduino ve rfid kartının haberleşmesi için SPI haberleşmeyi başlatıyorum.
  rfid2.PCD_Init();
  rfid2.PCD_Init();
  motor2.attach(ServoPIN);//servo motoru hangi pine bağladığımızı belirtiyoruz.
  
}

void loop() {

   if (! rfid2.PICC_IsNewCardPresent()) 
   {return;}
   if (! rfid2.PICC_ReadCardSerial()) 
   { return;}
  if(Serial.available()){ //eğer kontenjan kalmamış ise gelen değer durumu false a düşürcek böylece servo motor dönmeyecek ve kapı açılmayack.
    char gelen=Serial.read();
    if(gelen=='a'){
      
        motor2.write(0);
      }
  }    
   if (rfid2.uid.uidByte[0] == Id[0] && rfid2.uid.uidByte[1] == Id[1] && rfid2.uid.uidByte[2] == Id[2] && rfid2.uid.uidByte[3] == Id[3])
       {
        
        
        Serial.println("Cikis Yapildi"); 
        motor2.write(180);
        delay(2000);
        motor2.write(0);
    
       }
       else
       {
        Serial.println("Olumsuz");
       }
        
        rfid2.PICC_HaltA();

       
 }
    
