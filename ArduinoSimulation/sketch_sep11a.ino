#include "Adafruit_MCP23017.h"
Adafruit_MCP23017 mcp;
void setup() {
 Serial.begin(9600);
 mcp.begin();
 for (int i = 0; i<15; i++){
 mcp.pinMode(i,OUTPUT);
 }

}
void loop() {
 char com = Serial.read();
 if(digitalRead(23) == HIGH ){
 Serial.write("R");
 }
 if(digitalRead(24) == HIGH){
 Serial.write("G");
 }
 if(digitalRead(25)== HIGH){
 Serial.write("B");
 }

 if(com == '1'){
 if(mcp.digitalRead(0) == HIGH){
 mcp.digitalWrite(0, LOW);
 }
 else{
 mcp.digitalWrite(0, HIGH);
 }
 }
 else if(com == '2'){
 if(mcp.digitalRead(1) == HIGH){
 mcp.digitalWrite(1, LOW);
 }
 else{
 mcp.digitalWrite(1, HIGH);
 }
 }
 else if(com == '3'){
 if(mcp.digitalRead(2) == HIGH){
 mcp.digitalWrite(2, LOW);
 }
 else{
 mcp.digitalWrite(2, HIGH);
 }
 }
 else if(com == '4'){
 if(mcp.digitalRead(3) == HIGH){
 mcp.digitalWrite(3, LOW);
 }
 else{
 mcp.digitalWrite(3, HIGH);
 }
 }
 else if(com == '5'){
 if(mcp.digitalRead(4) == HIGH){
 mcp.digitalWrite(4, LOW);
 }
 else{
 mcp.digitalWrite(4, HIGH);
 }
 }
 else if(com == '6'){
 if(mcp.digitalRead(5) == HIGH){
 mcp.digitalWrite(5, LOW);
 }
 else{
 mcp.digitalWrite(5, HIGH);
 }
 }
 else if(com == '7'){
 if(mcp.digitalRead(6) == HIGH){
 mcp.digitalWrite(6, LOW);
 }
 else{
 mcp.digitalWrite(6, HIGH);
 }
 }
 else if(com == '8'){
 if(mcp.digitalRead(7) == HIGH){
 mcp.digitalWrite(7, LOW);
 }
 else{
 mcp.digitalWrite(7, HIGH);
 }
 }

 else if(com == 'U'){ //Timer UP
 mcp.digitalWrite(8, HIGH); //1
 delay(500);
 mcp.digitalWrite(8 , LOW);

 mcp.digitalWrite( 9, HIGH); //2
 delay(500);
 mcp.digitalWrite(9 , LOW);

 mcp.digitalWrite(8, HIGH); //3
 mcp.digitalWrite(9, HIGH);
 delay(500);
 mcp.digitalWrite(8, LOW);
 mcp.digitalWrite(9, LOW);

 mcp.digitalWrite(10, HIGH); //4
 delay(500);
 mcp.digitalWrite(10, LOW);

 mcp.digitalWrite(10, HIGH); //5
 mcp.digitalWrite(8, HIGH);
 delay(500);
 mcp.digitalWrite(10,LOW);
 mcp.digitalWrite(8, LOW);

 mcp.digitalWrite(9, HIGH); //6
 mcp.digitalWrite(10, HIGH);
 delay(500);
 mcp.digitalWrite(9, LOW);
 mcp.digitalWrite(10, LOW);

 mcp.digitalWrite(8, HIGH); //7
 mcp.digitalWrite(9, HIGH);
 mcp.digitalWrite(10, HIGH);
 delay(500);
 mcp.digitalWrite(8, LOW);
 mcp.digitalWrite(9, LOW);
 mcp.digitalWrite(10, LOW);

 mcp.digitalWrite(11,HIGH); //8
 delay(500);
 mcp.digitalWrite(11,LOW);

 mcp.digitalWrite(11,HIGH); //9
 mcp.digitalWrite(8,HIGH);
 delay(500);
 mcp.digitalWrite(11,LOW);
 mcp.digitalWrite(8,LOW);
 }

 else if (com == 'D'){

 mcp.digitalWrite(11,HIGH); //9
 mcp.digitalWrite(8,HIGH);
 delay(500);
 mcp.digitalWrite(11,LOW);
 mcp.digitalWrite(8,LOW);

 mcp.digitalWrite(11,HIGH); //8
 delay(500);
 mcp.digitalWrite(11,LOW);

 mcp.digitalWrite(8, HIGH); //7
 mcp.digitalWrite(9, HIGH);
 mcp.digitalWrite(10, HIGH);
 delay(500);
 mcp.digitalWrite(8, LOW);
 mcp.digitalWrite(9, LOW);
 mcp.digitalWrite(10, LOW);

 mcp.digitalWrite(9, HIGH); //6
 mcp.digitalWrite(10, HIGH);
 delay(500);
 mcp.digitalWrite(9, LOW);
 mcp.digitalWrite(10, LOW);

 mcp.digitalWrite(10, HIGH); //5
 mcp.digitalWrite(8, HIGH);
 delay(500);
 mcp.digitalWrite(10,LOW);
 mcp.digitalWrite(8, LOW);

 mcp.digitalWrite(10, HIGH); //4
 delay(500);
 mcp.digitalWrite(10, LOW);

 mcp.digitalWrite(8, HIGH); //3
 mcp.digitalWrite(9, HIGH);
 delay(500);
 mcp.digitalWrite(8, LOW);
 mcp.digitalWrite(9, LOW);

 mcp.digitalWrite( 9, HIGH); //2
 delay(500);
 mcp.digitalWrite(9 , LOW);

 mcp.digitalWrite(8, HIGH); //1
 delay(500);
 mcp.digitalWrite(8 , LOW);

 }

 else if (com == 'B'){ //buzzer
 if(mcp.digitalRead(12) == HIGH){
 mcp.digitalWrite(12, LOW);
 }
 else{
 mcp.digitalWrite(12, HIGH);
 }
 }

 else if (com == 'R'){ //motor clockwise
 if(mcp.digitalRead(13) == LOW && mcp.digitalRead(14) == HIGH){
 mcp.digitalWrite(13, LOW);
 mcp.digitalWrite(14, LOW);
 }
 else{
 mcp.digitalWrite(13, LOW);
 mcp.digitalWrite(14, HIGH);
 }
 }

 else if (com == 'L'){ //motor counter-clockwise
 if(mcp.digitalRead(13) == HIGH && mcp.digitalRead(14) == LOW){
 mcp.digitalWrite(13, LOW);
 mcp.digitalWrite(14, LOW);
 }
 else{
 mcp.digitalWrite(13, HIGH);
 mcp.digitalWrite(14, LOW);
 }
 }

}
