#include <stdio.h>
#include <stdlib.h>

struct node {
    int d;
    struct node *next;
};

void insertData(struct node** head, struct node** tail, int val) {
    struct node* link = (struct node*)malloc(sizeof(struct node));
    link->d = val;
    link->next = NULL;

    if (*head == NULL) {
        *head = *tail = link;
        (*tail)->next = *head; 
    } else {
        (*tail)->next = link;
        *tail = link;
        (*tail)->next = *head;
    }
}

void display(struct node* head) {
    if (head == NULL) return;

    struct node* ptr = head;
    do {
        printf("%d ", ptr->d);
        ptr = ptr->next;
    } while (ptr != head);
    printf("\n");
}

int main() {
    int val;
    struct node* head = NULL;
    struct node* tail = NULL;

    while (1) {
        scanf("%d", &val);
        if (val < 0)
            break;
        insertData(&head, &tail, val);
    }

    display(head);
    return 0;
}
