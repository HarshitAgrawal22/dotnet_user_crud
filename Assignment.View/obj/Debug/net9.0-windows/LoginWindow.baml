   M S B A M L   `   `   `  ����O  KAssignment.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModelAssignment.ViewModel  5   	    Assignment.View!   Assignment.View.LoginWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ovm@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModel     5   	     � Title$  Login��5   	   $	��550��6   $	��600��6$    � WindowStartupLocation$ CenterScreen=�60    � DataContext 5      )   #Assignment.ViewModel.LoginViewModel  5   
   .��5
      � ���#f8f9fa.+�5   
   ��  �� Padding$ 20q�6    �� CornerRadius$ 10��6   
����������#dee2e6$��1q�6Y   $��Center=�6m   $��Center=�6�   ._�5      �� $	��280��6   .+�5      �� $��
User Login��6   $��20(�6.   $
��Bold"�6<   $��0,0,0,20q�6N    �� TextAlignment$ Center=�6`   �� 5      $��Email��6   $��SemiBold"�6(   �� 5      $��0,5,0,15q�6V   $��28��6h   ��6   �� *Email+ �� UpdateSourceTrigger$ PropertyChanged=�6h   �� 5      $��Password��6   $��SemiBold"�6+   G� 5      -   5         G�Name$ PwdBox��5      $��0,5,0,15q�6.   $��28��6@   �� 5      $��Login��6   $��32��6J   ���#0078D7
�������$
��Bold"�6~   ��6)   �� *LoginCommand+6~   �� 5      
���  ��$��0,10,0,0q�6K   $ Center=�6]   ��6   �� *LoginMessage+6]   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�66   $��0,20,0,0q�6S   .+�5      �� $��Don't have an account? ��6    �� 5      $��Register Here��6   $	��4,2q�6Y   
������ 
������ ���#0078D7	 � Cursor$
	 Hand��6�   ��65   �� *RegisterCommand+6�   5      5      5      5      5      