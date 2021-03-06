#pragma once

// ������
struct List;

// �������� ������;
// ������� ���������� ��������� �� ������.
List *createList();

// �������� ������ �� �������;
// ������� ��������� ��������� �� ������.
bool isEmpty(List *list);

// ������� ���������� ����� ������;
// ��������� ��������� �� ������.
int listLength(List *list);

// ������� ��������� ��������, ���� ��� �� ���������� � ������; ����� ����������� ���������� ����� ��������;
// ��������� ��������� �� ������, ��������, ����������;
// ������� ���������� true, ���� �������� ���������; ����� false.
bool addNewValueToList(List *list, char *value, int quantity);

// ������� ���������, ���������� �� �������� � ������;
// ��������� ��������� �� ������, ��������;
// ���������� true, ���� ����������; false - �� ����������.
bool listContainsValue(List *list, char *value);

// ������� ���������� ������ �������� � ������;
// ��������� ��������� �� ������.
char *returnValueFromHead(List *list);

// ������� ���������� ���������� ������� �������� � ������;
// ��������� ��������� �� ������.
int quantityOfValuesFromHead(List *list);

// ������� ������� �������� �� ������;
// ������� ��������� ��������� �� ������.
void deleteValueFromHead(List *list);

// ����� ������ �� �����;
// ������� ��������� ��������� �� ������.
void printList(List *list);

// �������� ������;
// ������� ��������� ��������� �� ������.
void deleteList(List *list);