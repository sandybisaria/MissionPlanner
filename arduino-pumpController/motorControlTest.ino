
int E1 = 5;  
int M1 = 4; 
int E2 = 6;                      
int M2 = 7;                        
 
void setup() 
{ 
    pinMode(M1, OUTPUT);   
    pinMode(M2, OUTPUT); 
} 
 
void loop() 
{ 
  int value;
 //for(value = 0 ; value <= 255; value+=50) 
  //{ 
    digitalWrite(M1,HIGH);   
    digitalWrite(M2, HIGH);    
      
   
    analogWrite(E1, 255);   //PWM Speed Control
    analogWrite(E2, 255);   //PWM Speed Control
    delay(1500); 
    
    analogWrite(E1, 0);   //PWM Speed Control
    analogWrite(E2, 0);   //PWM Speed Control
    delay(1500); 
    
  //}  
}
/*
void setup(){
  //Setup Channel A
  pinMode(12, OUTPUT);//motor
  pinMode(9, OUTPUT);//brake
}

void loop(){
  digitalWrite(12, HIGH);//forward
  digitalWrite(9, LOW);//remove brake
  analogWrite(3, 255);//spin at full power
  delay(3000);
  
  digitalWrite(9, HIGH);//brake on
  delay(1000);
  
  //Backward
  digitalWrite(12, LOW);//backward direction
  digitalWrite(9, LOW);//remove brake
  analogWrite(3, 123);//Spin at 1/2 speed
  delay(3000);
  
  digitalWrite(9, HIGH);//brake on
  delay(1000):
  
}
*/

/*
void setup()
{
pinMode(Ain4, OUTPUT);
}

void loop()
{
digitalWrite(Ain4, LOW);
analogWrite(6, 100);
delay(5000);

analogWrite(6, 0);
delay(500);

digitalWrite(Ain4, HIGH);
analogWrite(6, 50);
delay(5000);

analogWrite(6, 255);
delay(500);
}
*/
