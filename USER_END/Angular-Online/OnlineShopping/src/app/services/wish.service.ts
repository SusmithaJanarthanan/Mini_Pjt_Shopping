// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class WishService {

//   constructor() { }
// }

import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Wishlist } from "../models/wishlist.model";
@Injectable()
export class WishService
{
    constructor(private getHttp:HttpClient,private addHttp:HttpClient,private removeHttp:HttpClient)
    {

    }

    public getWishlist(id:number)
    {
        return this.getHttp.get("http://localhost:61535/api/Wishlist/"+id);
    }

    public addToWishlist(wish:Wishlist)
    {
        return this.addHttp.post("http://localhost:61535/api/Wishlist/",wish);
    }
   /* public removeFromWishlist(wish:Wishlist)
    {
        return this.removeHttp.delete("http://localhost:61535/api/Wishlist/",wish);
    }*/
}
