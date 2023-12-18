/* declare pins for input */
const int UP_BUTTON = 2; // brown
const int DOWN_BUTTON = 3; // red
const int RIGHT_BUTTON = 4; // blue
const int LEFT_BUTTON = 5; // green
const int SHOOT_BUTTON = 6; // the odd one out
const int BAUD_RATE = 9600;

/* declare signals for communication */
const int UP_DIR = 1;
const int DOWN_DIR = 2;
const int RIGHT_DIR = 3;
const int LEFT_DIR = 4;
const int SHOOT = 5;

void setup() {
  /* poll input from hardware buttons */
  pinMode(UP_BUTTON, INPUT_PULLUP);
  pinMode(DOWN_BUTTON, INPUT_PULLUP);
  pinMode(RIGHT_BUTTON, INPUT_PULLUP);
  pinMode(LEFT_BUTTON, INPUT_PULLUP);
  pinMode(SHOOT_BUTTON, INPUT_PULLUP);
  
  /* stream at specified frequency */
  Serial.begin(BAUD_RATE);

}

void loop() {
  /* input loop */

  /* Movements */
  if(!digitalRead(UP_BUTTON) == HIGH){
    Serial.write(UP_DIR);
  }

  if(!digitalRead(DOWN_BUTTON) == HIGH){
    Serial.write(DOWN_DIR);
  }

  if(!digitalRead(RIGHT_BUTTON) == HIGH){
    Serial.write(RIGHT_DIR);
  }

  if(!digitalRead(LEFT_BUTTON) == HIGH){
    Serial.write(LEFT_DIR);
  }

  /* Fire laser beam */
  if(!digitalRead(SHOOT_BUTTON) == HIGH){
    Serial.write(SHOOT);
  }

  delay(10);

}
