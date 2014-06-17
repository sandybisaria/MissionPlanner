
int inputPin = 3;
int val = 0;
 
int E1 = 5;  
int M1 = 4; 
int E2 = 6;                      
int M2 = 7;   

void setup() 
{ 
    pinMode(M1, OUTPUT);   
    pinMode(M2, OUTPUT); 
    Serial.begin(9600);
} 
 
void loop() 
{
  digitalWrite(M1,HIGH);   
  digitalWrite(M2, HIGH);    
  for(int i = 0; i <1000; i++){
  val += analogRead(inputPin);
}
  Serial.println(abs(val)); 
  if(abs(val) > 22000)
  {          
    analogWrite(E1, 255);   //PWM Speed Control
    analogWrite(E2, 255);   //PWM Speed Control
    
  }
  else
  {
    analogWrite(E1, 0);   //PWM Speed Control
    analogWrite(E2, 0);   //PWM Speed Control
  }
  
  val = 0;
  delay(10);
}
