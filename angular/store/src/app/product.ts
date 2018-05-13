export class Product {
    id: string;
    name: string;
    code: string;
    categoryId: string;
    category: Category;
}

export class Category {
    id: string;
    name: string;
    code: string;
}
