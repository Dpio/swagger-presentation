import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { ProductsService } from '../products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: Product[];

  constructor(private productService: ProductsService) { }

  ngOnInit() {
    this.getHeroes();
  }

  getHeroes(): void {
    this.productService.getAll()
    .subscribe(heroes => this.products = heroes);
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.productService.add({ name } as Product)
      .subscribe(hero => {
        this.products.push(hero);
      });
  }

  delete(hero: Product): void {
    this.products = this.products.filter(h => h !== hero);
    this.productService.delete(hero).subscribe();
  }

}
