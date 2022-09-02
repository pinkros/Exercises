// Skriv ett program som frågar användaren efter ett tal mellan 1 och 100.
// Programmet ska ha ett hemligt tal lagrat i en variabel.
// Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet.
// Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det.
// Exempel: programmet har det hemliga talet 27. Användaren gissar på 50.
// Programmet skriver ut att användaren gissade för högt.
// Användaren gissar på 20. Programmet skriver ut att det var för lågt. Användaren gissar på 27.
// Programmet skriver ut att det var rätt och avslutas.
Random rnd = new Random();

var secretNum = rnd.Next(0, 100);
var guessNum = 0;

do { 

    
} while (guessNum != secretNum);