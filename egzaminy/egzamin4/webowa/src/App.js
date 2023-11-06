import './App.css';
import React, {useState} from "react";
import NewPost from './components/NewPost';
import Posts from './components/Posts';

function App() {
	const [isNewPostVisible, setIsNewPostVisible] = useState(false);
	function showNewPost(){
		setIsNewPostVisible(!isNewPostVisible);
	}
	return (
		<>
			<div className='baner'>
				<div className='banerTitle'>Blog</div>
				<div>
					<form onSubmit={showNewPost}>
						<button type='submit' className='banerButton'>Nowy post</button>
					</form>
				</div>
			</div>
			<NewPost/>
			<Posts/>
		</>
	);
}

export default App;
