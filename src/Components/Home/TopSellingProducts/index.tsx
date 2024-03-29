import React from 'react';
import ScrollListProducts from '../ScrollListProducts';
export default function TopSellingProducts(){
	return(
		<article className='customContainer mb-20'>
			<section className='flex max-sm:flex-col max-sm:items-center justify-between mb-8 mt-20'>
				<div>
					<h2 className='text-2xl font-bold text-stone-800  max-sm:pb-4'>Top Selling Products</h2>
				</div>
				<ul className='flex max-sm:justify-center flex-wrap gap-6 text-stone-800'>
					<li className='border-b-2 border-amber-400 px-2'><a href='#'>ALL</a></li>
					<li className='px-2'><a href='#'>ACCESSORIES</a></li>
					<li className='px-2'><a href='#'>CAMERAS & CAMCORDERS</a></li>
					<li className='px-2'><a href='#'>COMPUTERS & TABLETS</a></li>
					<li className='px-2'><a href='#'>ENTERTAINMENT</a></li>
				</ul>
			</section>
			<section  className='relative flex '>
				<ScrollListProducts listId={3}/>		
			</section>
			<hr />
		</article>
	);
}