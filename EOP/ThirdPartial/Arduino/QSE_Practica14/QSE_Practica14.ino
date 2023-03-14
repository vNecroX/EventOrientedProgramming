int pinLEDs[] = {13, 12, 11};
char stat;

void setup() {
  Serial.begin(9600);
  
  for(int i=0; i<3; i++)
    pinMode(pinLEDs[i], OUTPUT);
}

void loop() {
  if(Serial.available()){
    stat = Serial.read();

    if(stat == '1'){
      digitalWrite(pinLEDs[0], HIGH);
      digitalWrite(pinLEDs[1], LOW);
      digitalWrite(pinLEDs[2], LOW);
    }
      
    if(stat == '2'){
      digitalWrite(pinLEDs[0], LOW);
      digitalWrite(pinLEDs[1], HIGH);
      digitalWrite(pinLEDs[2], LOW);
    }

    if(stat == '0'){
      digitalWrite(pinLEDs[0], LOW);
      digitalWrite(pinLEDs[1], LOW);
      digitalWrite(pinLEDs[2], HIGH);
    }

    if(stat == '4'){
      digitalWrite(pinLEDs[0], LOW);
      digitalWrite(pinLEDs[1], LOW);
      digitalWrite(pinLEDs[2], LOW);
    }
  }
}
