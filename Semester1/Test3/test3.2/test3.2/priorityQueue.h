#pragma once

// ������� � ������������
struct PriorityQueue;

// �������� ������� � ������������;
// ������� ���������� ��������� �� �������.
PriorityQueue *createQueue();

// ���������� �������� � ������� � ������������;
// ������� ��������� ��������� �� �������, �������� � ��������� ���������.
void enqueue(PriorityQueue *queue, int value, int priority);

// ������� ���������� �������� � ��������� ����������� � ������� ��� �� ������� (���� ������� �����, ���������� -1);
// ��������� ��������� �� �������.
int dequeue(PriorityQueue *queue);

// �������� �������;
// ������� ��������� ��������� �� �������.
void deleteQueue(PriorityQueue *queue);