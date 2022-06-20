<h2 align="center">unit test *tsk* splended 👌</h2>
<p style="font-size:15px" align="center">
  <a href="#Introduction">Introduction</a> •
  <a href="#How-it-works">How it Works</a> •
  <a href="#emailware">Emailware</a> •
  <a href="#license">License</a>
</p>

<p align="center"></p>


# Introduction
Imagine you go to an oral exam and the teacher ask for this program first, it is not the best way to start your day with 😅, and it took me some time to understand how it works.

# How-it-works
The main method is called `Replace(string word, char replace, char replaceWith, int occurrence)` first parameter is the string you want to replace char in, second is what you want to replace, third is what you want to replace with, last one is the number of that occurrence that will be changed, hmmmmm not clear yet, here are some examples.

You send to `Replace()` these parameteres ("apple", 'p', 'b', 1) the output will be "abble", because the int is 1, the first occurance of the letter 'p' will be changed (not clear enough?) here is another one, these are the new parameters ("apppppple", 'p', 'b', 2) output this time will be "apbpbpble", now it make sense.


It was required to have two custom made exceptions first one `myIllegalParamException()` if the string input is null and `myNegativeParamException()` if the int is less than zero.


There are **4 unit tests** made to make sure it covers as many possibilities for input (including exceptions).

<img style="border-radius:10px;" align="right" src="https://github.com/Ahelsamahy/ReplaceInString/blob/main/assets/unitTest.png?raw=true" title="successful test cases" >

FirstOccurrence(): check when input is ("apple", 'p', 'b', 1) that will give "abble".

NegativeOccurrence(): trigger  `myNegativeParamException()`.

NullString(): trigger `myIllegalParamException()`.

SecondOccurrence():check when input is ("apppppple", 'p', 'b', 2) that will give "apbpbpble".



# Emailware
This project is an [emailware](https://en.wiktionary.org/wiki/emailware). Meaning, if you liked using this app or it has helped you in any way, I'd like you to send me an email at <ahmelsamahy@gmail.com> about anything you'd want to say about this software. I'd really appreciate it!

# License
If you have a project similar to this which you will use this instead in it or you may use this project, don't forget to mention me or send me an email about it.