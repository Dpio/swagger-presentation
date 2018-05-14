import { Component, OnInit, Inject } from '@angular/core';
import { ProductsService } from '../products.service';
import { ProductServiceProxy, Product } from '../../shared/service-proxies/service-proxies';
import { HttpClient } from '@angular/common/http';
import { Http } from '@angular/http';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  _productService: ProductServiceProxy;
  products: Product[];

  constructor(@Inject(Http) http: Http) {
    this._productService = new ProductServiceProxy(http, 'http://localhost:53995');
  }

  ngOnInit() {
    this.getProducts();
  }

  getProducts(): void {
    this._productService.getAll().subscribe(products => {
      this.products = products;
    });
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    // this.productService.add({ name } as Product)
    //   .subscribe(hero => {
    //     this.products.push(hero);
    //   });
  }

  delete(hero: Product): void {
    this.products = this.products.filter(h => h !== hero);
    // this.productService.delete(hero).subscribe();
  }

}
