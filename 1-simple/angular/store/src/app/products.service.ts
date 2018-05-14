import { Injectable } from '@angular/core';

@Injectable()
export class ProductsService {
  delete(arg0: any): any {
    console.log('delete');
  }
  add(arg0: any): any {
    console.log('add');
  }
  getAll(): any {
    console.log('getAll');
  }
}
