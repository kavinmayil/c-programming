#include <stdio.h>
#include <stdlib.h>

struct node {
    int d;
    struct node *next;
};

void insertData(struct node** head, int val) {
    struct node* link = (struct node*)malloc(sizeof(struct node));
    if (link == NULL) {
        printf("Memory allocation failed\n");
        return;
    }
    link->d = val;
    link->next = *head;
    *head = link; // Update head pointer
}

void display(struct node* head) {
    struct node* ptr = head;
    while (ptr != NULL) {
        printf("%d ", ptr->d);
        ptr = ptr->next;
    }
    printf("\n");
}

int main() {
    int val;
    struct node* head = NULL;
    
    while (1) {
        scanf("%d", &val);
        if (val < 0)
            break;
        insertData(&head, val);
    }
    
    display(head);
    
    return 0;
}
