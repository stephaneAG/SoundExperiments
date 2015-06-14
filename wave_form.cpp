// wave_form.cpp
//
// by StephaneAG - 2013
//
// simple program generating a wave form without the use of an external library for doing so
//
// to compile: -on Mac: g++ -o wave_form wave_form.cpp
//			   -on Linux: make wave_form.cpp


#include <iostream>
#include <cmath>
#include <stdint.h>

int main(){
	
	const double R=8000; // the sample rate ( the number of samples per second )
	const double C=261.625565; // the frequency of middle-C ( C4 ) ( hertz )
	const double F=R/256; // bytebeat frequency of 1*t due to 8-bit truncation ( hertz )
	const double V=127; // a volume constant
	
	// Tef Edit
	const double E4=329.63; // the frequency of middle-E ( E4 ) ( hertz )
	const long frq_steps= 20; // the 20Hz step ( hertz )
	
	for(int t=0; ;t++){
		
		//uint8_t temp = (sin(t*2*M_PI/R*C)+1)*V; // pure middle C sine wave
		
		//uint8_t temp = t/F*C; // middle C saw wave ( bytebeat style )
		
		//uint8_t temp = (t*5&t>>7) | (t*3&t>>10); // viznut bytebeat composition
		
		// ---- tests ____ //
		
		//uint8_t temp = (sin(t*2*M_PI/R*E4)+1)*V; // pure middle E sine wave ?
		
		//uint8_t temp =  (t*2&t>>10) ; // my bytebeat composition
		// Nb: after testing -> (t* <note height> &t >> <repeat speed>)
		
		//uint8_t temp =  (t*3&t>>10) ;
		//uint8_t temp =  (t*4&t>>5) ; // neat one ;p
		//uint8_t temp =  (t*4&t>>4) ; // same as above but with higher frequency
		//uint8_t temp =  (t*4&t>>3) ; // techno boum-boum ?
		//uint8_t temp =  (t*4&t>>2) ; // techno pa-pa-pa-pa-pa ...
		//uint8_t temp =  (t*4&t>>1) ; //  weird-rifle ?
		//uint8_t temp =  (t*4&t>>0) ; // ...
		//uint8_t temp =  (t*12&t>>4)  ;
		//uint8_t temp =  (t*12&t>>4) | (t*12&t>>5);
		//uint8_t temp =  (t*12&t>>4) | (t*40&t>>7) | (t*33&t>>9); // des barres ;D
		//uint8_t temp =  (t*12&t>>4) | (t*22&t>>7) | (t*33&t>>9); // same ;p
		//uint8_t temp =  (t*12&t>>4) | (t*5&t>>12) | (t*33&t>>9); // ok
		// (t*5&t>>7) | (t*3&t>>10) |
		
		//uint8_t temp = (sin(t*2*M_PI/R* ( C + t*frq_steps ) )+1)*V;
		
		uint8_t temp = (sin(t*2*M_PI/R* ( C + t*frq_steps ) )+1)*V;
		
		std::cout << temp;
		//std::cout << "hello again, world !";
		
	}
	
		
}