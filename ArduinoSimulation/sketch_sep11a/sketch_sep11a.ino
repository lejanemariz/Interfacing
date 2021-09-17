#include "Adafruit_MCP23017.h"
Adafruit_MCP23017 mcp;

bool pressed = false;

void setup()
{
  Serial.begin(9600);
  mcp.begin();
  for (int i = 0; i < 15; i++)
  {
    mcp.pinMode(i, OUTPUT);
  }
  pinMode(9, INPUT_PULLUP);
  pinMode(8, INPUT_PULLUP);
  pinMode(4, INPUT_PULLUP);
}

void loop()
{
  char com = Serial.read();
  //511Control
  if (digitalRead(9) == pressed )
  {
    Serial.write("R");
  }
  if (digitalRead(8) == pressed)
  {
    Serial.write("G");
  }
  if (digitalRead(4) == pressed)
  {
    Serial.write("B");
  }
//LED
  if (com == '1')
  {
    if (mcp.digitalRead(0) == HIGH)
    {
      mcp.digitalWrite(0, LOW);
    }
    else
    {
      mcp.digitalWrite(0, HIGH);
    }
  }
  else if (com == '2')
  {
    if (mcp.digitalRead(1) == HIGH) {
      mcp.digitalWrite(1, LOW);
    }
    else {
      mcp.digitalWrite(1, HIGH);
    }
  }
  else if (com == '3') {
    if (mcp.digitalRead(2) == HIGH) {
      mcp.digitalWrite(2, LOW);
    }
    else {
      mcp.digitalWrite(2, HIGH);
    }
  }
  else if (com == '4') {
    if (mcp.digitalRead(3) == HIGH) {
      mcp.digitalWrite(3, LOW);
    }
    else {
      mcp.digitalWrite(3, HIGH);
    }
  }
  else if (com == '5') {
    if (mcp.digitalRead(4) == HIGH) {
      mcp.digitalWrite(4, LOW);
    }
    else {
      mcp.digitalWrite(4, HIGH);
    }
  }
  else if (com == '6') {
    if (mcp.digitalRead(5) == HIGH) {
      mcp.digitalWrite(5, LOW);
    }
    else {
      mcp.digitalWrite(5, HIGH);
    }
  }
  else if (com == '7') {
    if (mcp.digitalRead(6) == HIGH) {
      mcp.digitalWrite(6, LOW);
    }
    else {
      mcp.digitalWrite(6, HIGH);
    }
  }
  else if (com == '8') {
    if (mcp.digitalRead(7) == HIGH) {
      mcp.digitalWrite(7, LOW);
    }
    else {
      mcp.digitalWrite(7, HIGH);
    }
  }

  else if (com == 'U') { //Timer UP
    zero();
    delay (500);
    one();
    delay (500);
    two();
    delay (500);
    three();
    delay (500);
    four();
    delay (500);
    five();
    delay (500);
    six();
    delay (500);
    seven();
    delay (500);
    eight();
    delay (500);
    nine();
    delay (500);
  }

  else if (com == 'D') { //Timer Down
    nine();
    delay (500);
    eight();
    delay (500);
    seven();
    delay (500);
    six();
    delay (500);
    five();
    delay (500);
    four();
    delay (500);
    three();
    delay (500);
    two();
    delay (500);
    one();
    delay (500);
    zero();
    delay (500);
  }

  else if (com == 'Z') { //buzzer
    if (mcp.digitalRead(12) == HIGH) {
      mcp.digitalWrite(12, LOW);
    }
    else {
      mcp.digitalWrite(12, HIGH);
    }
  }

  else if (com == 'C') { //motor clockwise
    if (mcp.digitalRead(13) == LOW && mcp.digitalRead(14) == HIGH) {
      mcp.digitalWrite(13, LOW);
      mcp.digitalWrite(14, LOW);
    }
    else {
      mcp.digitalWrite(13, LOW);
      mcp.digitalWrite(14, HIGH);
    }
  }

  else if (com == 'L') { //motor counter-clockwise
    if (mcp.digitalRead(13) == HIGH && mcp.digitalRead(14) == LOW) {
      mcp.digitalWrite(13, LOW);
      mcp.digitalWrite(14, LOW);
    }
    else {
      mcp.digitalWrite(13, HIGH);
      mcp.digitalWrite(14, LOW);
    }
  }
}
 //////////////////////////////////////////////////////////////////////////////////////////////////////
  void zero() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, LOW);
    mcp.digitalWrite(10, LOW);
    mcp.digitalWrite(11, LOW);
  }
  void one() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, LOW);
    mcp.digitalWrite(10, LOW);
    mcp.digitalWrite(11, HIGH);
  }
  void two() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, LOW);
    mcp.digitalWrite(10, HIGH);
    mcp.digitalWrite(11, LOW);
  }
  void three() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, LOW);
    mcp.digitalWrite(10, HIGH);
    mcp.digitalWrite(11, HIGH);
  }
  void four() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, HIGH);
    mcp.digitalWrite(10, LOW);
    mcp.digitalWrite(11, LOW);
  }
  void five() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, HIGH);
    mcp.digitalWrite(10, LOW);
    mcp.digitalWrite(11, HIGH);
  }
  void six() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, HIGH);
    mcp.digitalWrite(10, HIGH);
    mcp.digitalWrite(11, LOW);
  }
  void seven() {
    mcp.digitalWrite(8, LOW);
    mcp.digitalWrite(9, HIGH);
    mcp.digitalWrite(10, HIGH);
    mcp.digitalWrite(11, HIGH);
  }
  void eight() {
    mcp.digitalWrite(8, HIGH);
    mcp.digitalWrite(9, LOW);
    mcp.digitalWrite(10, LOW);
    mcp.digitalWrite(11, LOW);
  }
  void nine() {
    mcp.digitalWrite(8, HIGH);
    mcp.digitalWrite(9, LOW);
    mcp.digitalWrite(10, LOW);
    mcp.digitalWrite(11, HIGH);
  }
