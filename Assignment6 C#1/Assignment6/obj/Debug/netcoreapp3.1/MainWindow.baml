   M S B A M L   `   `   `  ����F  BAssignment6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment6Assignment6  5   	       Assignment6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment6     5   	     � Title$!  ToDo Reminder by Alex Haase��5   	   $	��450��6-   $	��800��6:    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$	 New��5
      6'     5   
   -   5        $ Close��5      6)     5   
   -   5        $
 Save��5      6(     5   
   -   5        $
 Open��5      6(    J� InputBindings 5      �� 5   
   
 �� Key$ N��6    �� 	Modifiers$
 Ctrlf�6    �� Command$	 New��6.   �� 5   
   $ F4��6   $	 Altf�6   $ Close��6.   .��5      � .+�5   
   o� -   5         o�Name$
 menu��5      $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $	��New��6    m� InputGestureText$ Ctrl+N��6(   	 m� Command$		 New��6B   �� 5      m� 5      $��Open data file��6   $
	 Open��63   m� 5      $��SaveDataFile��6   $
	 Save��61   �� 5      m� 5      $
��Exit��6   $ Alt+F4��6)   $	 Close��6C   5      m� 5      $
��Help��6   .@�5      m� $��About...��6   5      5       �� 5!   
   -   5        
 ��Name$
 dateAndTimeLabel��5!      $��Date and time��6*   $
��Left=�6B   $��	20,30,0,0q�6]   $	��Top=�6p   �� 5"   
   -   5        $
 	toDoLabel��5"      $��To do��6#   $
��Left=�63   $��	20,55,0,0q�6N   $	��Top=�6a   �� 5#   
   -   5        $
 priorityLabel��5#      $��Priority��6'   $
��Left=�6:   $��
370,30,0,0q�6U   $	��Top=�6i   (  "System.Windows.Controls.DatePicker  5%   
   -	   5          Name$ 
datePicker��5%      $
��Left=�6)   $��
130,30,0,0q�6D   $	��Top=�6X   $	��120��6p    � ToolTip 5&      _� 5'      .��6   Click to select date.5)      5+      �� 5,   
   -
   5         ��Name$ hourComboBox��5,      $
��Left=�6)   $��
260,30,0,0q�6D   $	��Top=�6X   $��45��6p    5-      _� 5.      .��6   Click to select hour.50      52      �� 53   
   -   5        $ minuteComboBox��53      $
��Left=�6+   $��
315,30,0,0q�6F   $	��Top=�6Z   $��45��6r    54      _� 55      .��6   Click to select minute.57      59      �� 5;   
   -   5        $ priorityComboBox��5;      $
��Left=�6-   $��
430,30,0,0q�6H   $	��Top=�6\   $	��120��6t   �� 5<   
   -   5         ��Name$ toDoTextBox��5<      $
��Left=�6'   $��
130,60,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��420��6�   �� 5=   
   -   5         ��Name$ 	addButton��5=      $	��Add��6$   $
��Left=�62   $��
200,90,0,0q�6M   $	��Top=�6a   $	��100��6y   6�   �� 5>   
   -   5         ��Name$ toDoGroupBox��5>      $��To Do��6)   $��Bottom=�68   $	��300��6S   $��10,10,10,10q�6`   .��5?      � .+�5@      �� -   5         ��Name$ listView��5@      $��10,10,10,50q�6-    �� View 5A      �� 5B      .P�5C      �� $
��Date��6-    �� Width$ 80��6;    �� DisplayMemberBinding 6F   �� *TaskDateString+�� 5D      $
��Hour��6-   $ 60��6;    6F   �� *TaskTimeString+�� 5E      $��Priority��6-   $	 100��6?    6K   �� *
Priority+�� 5F      $��Description��6-   $	 440��6B    6N   �� *Description+5G      5I      �� 5J      -   5        $ changeButton��5J      $��Change��6/   $
��Left=�6@   $��100,10,10,10q�6[   $��25��6q   $	��100��6}   $��Bottom=�6�   ${�False��6�   �� 5K      -   5        $ deleteButton��5K      $��Delete��6/   $
��Left=�6@   $��220,10,10,10q�6[   $��25��6q   $	��100��6}   $��Bottom=�6�   ${�False��6�   �� 5L      -   5        $
 
timerLabel��5L      $
��Time��6,   $��Right=�6;   $��0,0,5,5q�6W   $��Bottom=�6h   $��18(�6�   5N      5O      5R      5S      