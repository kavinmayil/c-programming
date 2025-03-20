#include <stdio.h>
#include <stdlib.h>

struct node {
    int d;
    struct node *next;
    struct node*prev;
};

void insertData(struct node** head,struct node**tail,int val) {
    struct node* newNode = (struct node*)malloc(sizeof(struct node));
    newNode->d = val;
    newNode->next =newNode->prev=NULL ;
    if(*head==NULL){
        *head=*tail=newNode;
    }
    else{
        (*tail)->next=newNode;
        newNode->prev=*tail;
        *tail=newNode;
    }
}

void display(struct node* head) {
    struct node* ptr = head;
    while (ptr != NULL) {
        printf("%d ", ptr->d);
        ptr = ptr->next;
    }
    printf("\n");
}

void displayt(struct node* tail) {
    struct node* ptr = tail;
    while (ptr != NULL) {
        printf("%d ", ptr->d);
        ptr = ptr->prev;
    }
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
        insertData(&head,&tail, val);
    }
    
    display(head);
    displayt(tail);
    return 0;
}
