﻿#include <stdio.h>
#include "tree.h"

void begin()
{
	printf("Enter:\n 0 - log off\n");
	printf(" 1 - Add value by key\n");
	printf(" 2 - Get value by key\n");
	printf(" 3 - Check key availability\n");
	printf(" 4 - Delete key and value\n");
}

bool tests()
{
	Tree *tree = createTree();
	char value[5] = "asdf";
	bool testsPassed = !contains(tree, 1);

	addValue(tree, 25, value);
	addValue(tree, 10, value);
	addValue(tree, 40, value);
	addValue(tree, 45, value);
	addValue(tree, 35, value);
	addValue(tree, 15, value);
	addValue(tree, 20, value);
	addValue(tree, 7, value);

	testsPassed = testsPassed && contains(tree, 7) && !contains(tree, 5);
	deleteValue(tree, 25);
	deleteValue(tree, 10);
	deleteValue(tree, 7);
	deleteValue(tree, 5);
	testsPassed = testsPassed && !contains(tree, 7) && !contains(tree, 25) && contains(tree, 40);

	deleteTree(tree);
	return testsPassed;
}

int main()
{
	if (!tests())
	{
		printf("Testing error\n");
		return 1;
	}

	int input = 0;
	bool shouldGoOut = false;
	Tree *tree = createTree();
	while (!shouldGoOut)
	{
		begin();
		scanf("%d", &input);
		int key = 0;
		switch (input)
		{
		case 0:
			shouldGoOut = true;
			break;
		case 1:
		{
			printf("Enter key: ");
			scanf("%d", &key);

			printf("Enter value: ");
			char value[1000] = {};
			scanf("%s", value);

			addValue(tree, key, value);
			break;
		}
		case 2:
		{
			printf("Enter key: ");
			scanf("%d", &key);

			char *value = getValue(tree, key);
			printf((value == nullptr) ? "Value for this key not found" : "Value: %s", value);
			printf("\n");
			delete[] value;
			break;
		}
		case 3:
			printf("Enter key: ");
			scanf("%d", &key);

			printf(contains(tree, key) ? "The key exists" : "The key does not exist");			
			printf("\n");
			break;
		case 4:
			printf("Enter key: ");
			scanf("%d", &key);

			deleteValue(tree, key);
			break;
		default:
			printf("Invalid input, try again\n");
			break;
		}
		printf("\n");
	}
	deleteTree(tree);
	return 0;
}