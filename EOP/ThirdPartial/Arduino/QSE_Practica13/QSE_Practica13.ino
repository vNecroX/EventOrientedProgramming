int pinLED = 13;
char stat;

void setup() {
  Serial.begin(9600);
  pinMode(pinLED, OUTPUT);
}

void loop() {
  if(Serial.available()){
    stat = Serial.read();

    if(stat == '1')
      digitalWrite(pinLED, HIGH);
      
    if(stat == '0')
      digitalWrite(pinLED, LOW);
  }
}
