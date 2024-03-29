'use client';
import React from 'react';
import CardProduct from '../CardProduct';
import { MdArrowForwardIos } from 'react-icons/md';

interface TypelistId{
	listId: number
}

function scrollButtons(scrollSide:string,listNumber:number){
	scrollSide == 'left' ? document.getElementById(`listProducts${listNumber}`)!.scrollLeft -= 290 : document.getElementById(`listProducts${listNumber}`)!.scrollLeft += 290;
}

export default function ScrollListProducts({listId}:TypelistId){
	return(
		<section className='relative flex mb-20 overflow-x-hidden'>
			<div id={`listProducts${listId}`} className='flex max-md:pl-0 pl-4 gap-4 items-center overflow-x-hidden max-md:overflow-x-scroll scroll-smooth'>
				<CardProduct sale={true} topProduct={true} />
				<CardProduct newProduct={true} topProduct={true} />
				<CardProduct topProduct={true} />
				<CardProduct newProduct={true} topProduct={true} />
				<CardProduct newProduct={true} topProduct={true} />
				<CardProduct newProduct={true} topProduct={true} />
				<CardProduct newProduct={true} topProduct={true} />
				<CardProduct newProduct={true} sale={true} />
				<CardProduct newProduct={true} />
				<CardProduct newProduct={true} />
			</div>
			<div id='ScrollButtonRight' 
				className='opacity-80 h-full flex items-center justify-center w-8 absolute right-0 cursor-pointer  max-md:hidden' 
				style={{background:'#FFFE', boxShadow:'-4px 0px 4px #8884'}} 
				onClick={() => scrollButtons('right',listId)}
			> 
				<MdArrowForwardIos className='text-xl'/>
			</div>
			<div id='ScrollButtonLeft' 
				className='opacity-80 h-full flex items-center justify-center w-8 absolute left-0 cursor-pointer  max-md:hidden' 
				style={{background:'#FFFE', boxShadow:'4px 0px 4px #8884'}} 
				onClick={() => scrollButtons('left',listId)}> 
				<MdArrowForwardIos className='text-xl rotate-180'/>
			</div>
		</section>
	);
}