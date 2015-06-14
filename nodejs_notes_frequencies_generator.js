// yup, a JS script executed from the terminal thanks to NodeJS
// to execute: 'node <script name>'

var fs = require('fs');
console.log("\n");
console.log("Notes Frequencies Generator v0.1a ...");
console.log("by StephaneAG - 2013 \n");

// the setup variables
var iterationCounter = 0; // to display/print the iteration N¡
var currentFrequency = 440; // the frequency we're starting with, in Hz ( hertz )
var roundedCurrentFrequency = 440;
var currentNote = "A"; // the note corresponding to that frequency ( here the "A" / "LA" )
var currentOctave = 4; // the current note's octave ( here the note is indeed "A4" )
var waveVelocity = 345; // the speed of the sound wave, wich in the [current] laws of physics seems to depend on the medium and its temperature ( normally about 345 m/s in the air at 'room temperature' )
var currentWaveLength = 78.4; // what's supposed to be the wave length of the "A" / "LA" 4 with a frequency of 440 Hz
var roundedCurrentWaveLength = 78.4;
var stream = fs.createWriteStream('generated_notes_frequencies.txt'); // we create a file output for thre stream we're gonna use

// display the inital setup to stdout
console.log( "Iteration N:" + iterationCounter + ", Note: " + currentNote + " Octave:" + currentOctave + 
			  " Frequency: " + roundedCurrentFrequency + " Hz" + " ( " + currentFrequency + " Hz" + " )" + 
			  " Wave length: " + roundedCurrentWaveLength + " cm" + " ( " + currentWaveLength + " cm" + " )" +  
			  "\n" );

stream.once('open', function(fd){ // we open the stream to be ready to write in it
	
	// display/print out initial setup data to the stream that's attached to the file we want to write to
	stream.write( "Iteration N:" + iterationCounter + ", Note: " + currentNote + " Octave:" + currentOctave + 
				  " Frequency: " + roundedCurrentFrequency + " Hz" + " ( " + currentFrequency + " Hz" + " )" + 
				  " Wave length: " + roundedCurrentWaveLength + " cm" + " ( " + currentWaveLength + " cm" + " )" +  
				  "\n" );
	
	//while( currentFrequency < 20000 ){ // while we're still in the 'human hearing range'
	//while( currentFrequency < 2000 ){ // for test purposes ;p
	while( currentFrequency < 22000 ){ // for other test purpose ;D
		
		// calculate the new note/tone frequency
		currentFrequency = currentFrequency * Math.pow( Math.pow( 2, (1/12) ), 1); // original formula being " Fx = y * (1.059463...)^x "
		
		// calculate the new wavelength depending on the new frequency and the wave velocity
		currentWaveLength = ( waveVelocity / currentFrequency ) * 100; // original formula being " A = V / F "
		
		// deduce the new note & its octave depending on the last one saved
		if( currentNote == "A" ){
			currentNote = "A#/Bb";
		} else if( currentNote == "A#/Bb" ){
			currentNote = "B";
		} else if( currentNote == "B" ){
			currentNote = "C";
			currentOctave++; // increment the current octave by one
		} else if( currentNote == "C" ){
			currentNote = "C#/Db";
		} else if( currentNote == "C#/Db" ){
			currentNote = "D";
		} else if( currentNote == "D" ){
			currentNote = "D#/Eb";
		} else if( currentNote == "D#/Eb" ){
			currentNote = "E";
		} else if( currentNote == "E" ){
			currentNote = "F";
		} else if( currentNote == "F" ){
			currentNote = "F#/Gb";
		} else if( currentNote == "F#/Gb" ){
			currentNote = "G";
		} else if( currentNote == "G" ){
			currentNote = "G#/Ab";
		} else if( currentNote == "G#/Ab" ){
			currentNote = "A";
		}
		
		// get the rounded frequency
		roundedCurrentFrequency = Math.round( currentFrequency * 100 ) / 100; // round it to two decimals after the comma
		
		// get the rounded wave length
		roundedCurrentWaveLength = Math.round( currentWaveLength * 10 ) / 10; // round it to one decimal after the comma
		
		// reflect the iteration using our iterationCounter
		iterationCounter++;
		
		// display/print out data generated to stdout and to the stream that's attached to the file we want to write to
		stream.write( "Iteration N:" + iterationCounter + ", Note: " + currentNote + " Octave:" + currentOctave + 
					  " Frequency: " + roundedCurrentFrequency + " Hz" + " ( " + currentFrequency + " Hz" + " )" + 
					  " Wave length: " + roundedCurrentWaveLength + " cm" + " ( " + currentWaveLength + " cm" + " )" +  
					  "\n" );
					  
		console.log( "Iteration N:" + iterationCounter + ", Note: " + currentNote + " Octave:" + currentOctave + 
					  " Frequency: " + roundedCurrentFrequency + " Hz" + " ( " + currentFrequency + " Hz" + " )" + 
					  " Wave length: " + roundedCurrentWaveLength + " cm" + " ( " + currentWaveLength + " cm" + " )" +  
					  "\n" );
	}
	
	
	stream.end(); // discard any further write to the stream and close the file that it was attached to
});

//console.log("Done ! > exiting ...");