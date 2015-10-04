# MassFileRenamer
A simple tool to mass rename files

Rename Group
  Base Name TextBox
    The name to be used in the new file names
  Number Positions NumericUpDown
    The amount of zero padding on the output file names
      A value of 5 will output: 00001, 00002, 00003, ...
      A value of 3: 001, 002, 003, ...
  Sample Output Filename
    An example of the name that will be given to the files when the rename operation is run
    
Filter Options - To narrow down the list of files that will be renamed
  Included Extensions 
    Only the files whos extensions are selected in this listbox will be shown in the file list
  Match Filter
    Only the files whos names contain the text in this textbox will be shown in the file list
    

