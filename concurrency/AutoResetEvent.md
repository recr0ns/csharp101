#AutoResetEvent
� ������� �������� `AutoResetEvent` ������������ ��� �������� �������� ����� ����� ��������.

`AutoResetEvent` ��������� ������� ����. ���� �� `false`, ����� �� ��������� �����, ����� ������������.

����� ����� ������������� ���� ��������� � ������� ������ *WaitOne*. 
��� ���� ������ ����� ������ ��� �������������� � �������������� ������ *Set*.

##Examples
###Case 1
������ �������� ������ �� ������, ��� ��������� ����������. � �� ����� ��� ���������� ��������� ������� �����.
����� ����, ��� �� �������� ������, �� �������� *Set*, ��� �������� � ��������������� �������� ������.

###Case 2
������: ���� ����� ������� ������� ������ �����, ������ - ������� ��������. ����� ������� � ������� ������ ���������� �� ������� ������.

��� ����� ����� ������������ 2� ���������� `AutoResetEven` �, "���������" ������������, ��������� ����������� ���������.
������ ����� ���������� ���� �����, ����� ����� ������������ ������ ����� � ����� ����� �����������, ������ �������� �������.
������ �����, ����� ���������������, ���������� ���� ����� � ������������ ������ �����, ����� ���� ��� �����������.

_���� � ����� ������� ����� �� ���������� ���������� ���������, �� ���� �� ������� ������������� ��������, ������ ������� �� ������, ������� ��� ����������_

###Case 3
������, ����� ��������� ������� ����������� �� ���� `AutoResetEvent`.
�� �������� ����� �� ����� ��� ��������������� ����� �����������. � ����� �������� ���������������� ���������� ������� � �������������� �� ������� ����������.