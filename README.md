# Lab5-UsingWebAPI

As an executive decision I decided to only do two part jokes because all of the single jokes were really bad, and not the funny bad

### Error Time Line 

An error occured with the properties I created for the joke class. I had flag meta as a list, thinking each index would contain the bool value of the flags. I hence changed it to an object that has each bool value as a properties.

Another error occured when I had the property error assigned to a string while the Json returned it as a bool. 

I had many small errors while creating a url for the GetAsync method due to punctuation changing based on various user selections. I fixed this with various if statments and other checks 

A majority of my other errors were caused from my switch statement and having be dynamic selection of filters 

The final error I encountered was the amount for returning jokes. When more that one joke is requested, the JSON completely reformats. Due to this, I had struggles getting it to deserialize in my new class I created for it. After spending the several hours on this one bug alone, I abandoned using the url to add the amount of jokes and instead looped over the url for a single joke multiple times. This was the only way I could get it to function 
