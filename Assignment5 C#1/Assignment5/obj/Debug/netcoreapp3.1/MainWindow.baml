   M S B A M L   `   `   `  ����F  BAssignment5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment5Assignment5  5   	       Assignment5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment5     5   	     � Title$%  Customer Registry By Alex Haase��5   	   $	��450��61   $	��800��6>    � 
ResizeMode$ CanMinimize=�6J   .��5	      � .+�5
   
   �� -   5         ��Name$ listView��5
      $��10,10,347,55q�6%    �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 30��61    �� DisplayMemberBinding 6<   �� *ID+�� 5      $��
First name��6%   $ 80��69    6D   �� *Contact.FirstName+�� 5      $��Surname��6%   $	 100��66    6B   �� *Contact.LastName+�� 5      $��Office phone��6%   $	 100��6;    6G   �� *Contact.Phone.Work+�� 5      $��Office E-mail��6%   $	 100��6<    6H   �� *Contact.Email.Work+5      5      �� 5   
   -   5         ��Name$ textBox��5      $��Right=�6#   $��
0,10,10,10q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��380��6   $	��320��6�   ${�False��6�   �� 5   
   -   5         ��Name$ 	addButton��5      $	��Add��6$   $
��Left=�62   $��	40,0,0,10q�6M   $��Bottom=�6`   $��30��6{   $	��120��6�   6�   �� 5   
   -   5        $ 
editButton��5      $
��Edit��6%   $
��Left=�64   $��
170,0,0,10q�6O   $��Bottom=�6c   $��30��6~   $	��120��6�   6�   �� 5   
   -   5        $ deleteButton��5      $��Delete��6'   $
��Left=�68   $��
300,0,0,10q�6S   $��Bottom=�6g   $��30��6�   $	��120��6�   6�   5      5      